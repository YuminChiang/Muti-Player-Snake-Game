using SuperSimpleTcp;
using System;
using System.Text;
using static Client.TCPClient;
using static System.Formats.Asn1.AsnWriter;

enum Direction
{
    Up, Down, Left, Right
}

namespace Client
{
    public partial class TCPClient : Form
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

        private const int BlockSize = 20;
        private readonly List<Block> _snake = new List<Block>();
        private Block _food;
        private Direction _direction = Direction.Down;

        private const int TimerInterval = 50; //timer更新速度
        private readonly Random _random = new Random();

        public bool isAlive;

        SimpleTcpClient _client;
        private string rcv_packet;
        public TCPClient()
        {
            InitializeComponent();
            //btnConnect.Enabled = false;
            btnDisc.Enabled = false;
            panel1.Width = 500;
            panel1.Height = 420;
            _snake.Add(new Block(panel1.Left, panel1.Top));
            _food = GenerateFood(); //生出食物
            RefreshTimer.Interval = TimerInterval;
            RefreshTimer.Start();
        }

        private void Connected(object sender, ConnectionEventArgs e)
        {

        }
        private void Disconnected(object sender, ConnectionEventArgs e)
        {

        }
        private void DataReceived(object sender, DataReceivedEventArgs e)
        {
            rcv_packet = Encoding.UTF8.GetString(e.Data);
            handle_pkt();
        }

        private void handle_pkt()
        {
            char command = rcv_packet[0];
            string data = rcv_packet.Substring(1);

        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            lbxStatus.Items.Clear();
            lbxStatus.Items.Add($"Connecting to the server. . .{Environment.NewLine}");
            try
            {
                _client = new SimpleTcpClient($"{tbxIP.Text}:{tbxPort.Text}");
                _client = new SimpleTcpClient("127.0.0.1");
                _client.Events.Connected += Connected;
                _client.Events.Disconnected += Disconnected;
                _client.Events.DataReceived += DataReceived;
                _client.Connect();
                lbxStatus.Items.Add($"{tbxName.Text} connected.{Environment.NewLine}");
                btnConnect.Enabled = false;
                btnDisc.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbxStatus.Items.Add($"Client connection failed.{Environment.NewLine}");
            }
        }

        private void btnDisc_Click(object sender, EventArgs e)
        {
            lbxStatus.Items.Add($"{tbxName.Text} disconnect.{Environment.NewLine}");
            try
            {
                btnConnect.Enabled = true;
                btnDisc.Enabled = false;
                _client.Events.Connected -= Connected;
                _client.Events.Disconnected -= Disconnected;
                _client.Events.DataReceived -= DataReceived;
                _client.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TCPClient_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, panel1.Left, panel1.Top, panel1.Width, panel1.Height);
            foreach (Block block in _snake)
            {
                e.Graphics.FillRectangle(Brushes.Blue, block.X, block.Y, BlockSize, BlockSize);
            }
            e.Graphics.FillRectangle(Brushes.Red, _food.X, _food.Y, BlockSize, BlockSize);
        }

        private void TCPClient_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    _direction = _direction == Direction.Down ? Direction.Down : Direction.Up;
                    break;
                case Keys.Down:
                    _direction = _direction == Direction.Up ? Direction.Up : Direction.Down;
                    break;
                case Keys.Left:
                    _direction = _direction == Direction.Right ? Direction.Right : Direction.Left;
                    break;
                case Keys.Right:
                    _direction = _direction == Direction.Left ? Direction.Left : Direction.Right;
                    break;
            }
            make_pkt("k" + _direction.ToString());
        }

        private void make_pkt(string pkt)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(pkt);
            _client.Send(pkt);
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            Refresh();
            Block newHead = new Block(_snake.Last().X, _snake.Last().Y);
            //判斷方向移動
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
            _snake.Add(newHead);
            if (newHead.X == _food.X && newHead.Y == _food.Y)
            {
                _food = GenerateFood();
            }
            else
            {
                _snake.RemoveAt(0);
            }
        }
        private Block GenerateFood()
        {
            int maxX = panel1.Width / BlockSize;
            int maxY = panel1.Height / BlockSize;

            int x = _random.Next(maxX) * BlockSize + panel1.Left;
            int y = _random.Next(maxY) * BlockSize + panel1.Top;
            return new Block(x, y);
        }

    }
}

