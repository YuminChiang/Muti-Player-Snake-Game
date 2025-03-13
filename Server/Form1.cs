using SuperSimpleTcp;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    enum Direction
    {
        Up, Down, Left, Right
    }
    public partial class TCPServer : Form
    {
        public class Block
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Block(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        SimpleTcpServer _server;
        List<string> clientsName = new List<string>();
        List<string> clientsConnected = new List<string>();
        string rcv_pkt;


        private Direction _direction;
        private readonly Random _random = new Random();
        public TCPServer()
        {
            InitializeComponent();
            btnStart.Enabled = true;
            btnClose.Enabled = false;
            tbxIP.Select();
            tbxIP.Text = GetIpAddress();
        }

        private string GetIpAddress()
        {
            string hostName = Dns.GetHostName();
            IPAddress[] ipList = Dns.GetHostEntry(hostName).AddressList;

            foreach (IPAddress ip in ipList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return tbxIP.Text;
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            lbxServerStatus.Items.Clear();
            lbxServerStatus.Items.Add($"Starting server. . .{Environment.NewLine}");
            try
            {
                _server = new SimpleTcpServer($"{tbxIP.Text}:{tbxPort.Text}");
                _server.Events.ClientConnected += Events_ClientConnected;
                _server.Events.ClientDisconnected += Events_ClientDisconnected;
                _server.Events.DataReceived += Events_DataReceived;
                _server.Start();
                lbxServerStatus.Items.Add($"Server opened.{Environment.NewLine}");
                btnStart.Enabled = false;
                btnClose.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbxServerStatus.Items.Add($"Server start failed.{Environment.NewLine}");
            }
        }

        private void Events_ClientConnected(object? sender, ConnectionEventArgs e)
        {
            Invoke(new Action(() =>
            {
                clientsConnected.Add(e.IpPort);
                lbxConnected.Items.Add(e.IpPort);
                lbxServerStatus.Items.Add($"{e.IpPort} connected.");
            }));
            // init pos
            // init dir
            // apple

        }
        private void Events_ClientDisconnected(object? sender, ConnectionEventArgs e)
        {
            Invoke(new Action(() =>
            {
                clientsConnected.Remove(e.IpPort);
                lbxConnected.Items.Remove(e.IpPort);
                lbxServerStatus.Items.Add($"{e.IpPort} disconnected.");
            }));
        }
        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            rcv_pkt = Encoding.UTF8.GetString(e.Data);
            handle_pkt();
        }

        private void handle_pkt()
        {
            char command = rcv_pkt[0];
            string data = rcv_pkt.Substring(1);
            switch (command)
            {
                case 'k':
                    Updata_pos(data);
                    break;
            }
        }

        private void Updata_pos(string data)
        {
            switch (_direction)
            {
                case Direction.Up:
                    newHead.Y -= BlockSize;
                    if (newHead.Y < panel1.Top)
                        newHead.Y = panel1.Height + panel1.Top - BlockSize;
                    break;
                case Direction.Down:
                    newHead.Y += BlockSize;
                    if (newHead.Y > panel1.Height + panel1.Top - BlockSize)
                        newHead.Y = panel1.Top;
                    break;
                case Direction.Left:
                    newHead.X -= BlockSize;
                    if (newHead.X < panel1.Left)
                        newHead.X = panel1.Width + panel1.Left - BlockSize;
                    break;
                case Direction.Right:
                    newHead.X += BlockSize;
                    if (newHead.X > panel1.Width + panel1.Left - BlockSize)
                        newHead.X = panel1.Left;
                    break;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            lbxServerStatus.Items.Add($"Server closed.{Environment.NewLine}");
            try
            {
                _server.Events.ClientConnected -= Events_ClientConnected;
                _server.Events.ClientDisconnected -= Events_ClientDisconnected;
                _server.Events.DataReceived -= Events_DataReceived;
                _server.Stop();
                btnStart.Enabled = true;
                btnClose.Enabled = false;
                foreach (string client in lbxConnected.Items)
                {
                    _server.DisconnectClient(client);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}