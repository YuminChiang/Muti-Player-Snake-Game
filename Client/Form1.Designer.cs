namespace Client
{
    partial class TCPClient
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbIP = new Label();
            lbPort = new Label();
            lbName = new Label();
            gbxPlayer = new GroupBox();
            lbxPlayer = new ListBox();
            btnConnect = new Button();
            btnDisc = new Button();
            gbxClientStatus = new GroupBox();
            lbxStatus = new ListBox();
            panel1 = new Panel();
            RefreshTimer = new System.Windows.Forms.Timer(components);
            tbxIP = new TextBox();
            tbxPort = new TextBox();
            tbxName = new TextBox();
            gbxPlayer.SuspendLayout();
            gbxClientStatus.SuspendLayout();
            SuspendLayout();
            // 
            // lbIP
            // 
            lbIP.AutoSize = true;
            lbIP.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbIP.Location = new Point(524, 19);
            lbIP.Name = "lbIP";
            lbIP.Size = new Size(143, 20);
            lbIP.TabIndex = 0;
            lbIP.Text = "Server IP Address";
            // 
            // lbPort
            // 
            lbPort.AutoSize = true;
            lbPort.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbPort.Location = new Point(524, 54);
            lbPort.Name = "lbPort";
            lbPort.Size = new Size(160, 20);
            lbPort.TabIndex = 1;
            lbPort.Text = "Server Port Number";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbName.Location = new Point(524, 89);
            lbName.Name = "lbName";
            lbName.Size = new Size(94, 20);
            lbName.TabIndex = 4;
            lbName.Text = "User Name";
            // 
            // gbxPlayer
            // 
            gbxPlayer.Controls.Add(lbxPlayer);
            gbxPlayer.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbxPlayer.Location = new Point(524, 121);
            gbxPlayer.Name = "gbxPlayer";
            gbxPlayer.Size = new Size(266, 182);
            gbxPlayer.TabIndex = 6;
            gbxPlayer.TabStop = false;
            gbxPlayer.Text = "Player List";
            // 
            // lbxPlayer
            // 
            lbxPlayer.FormattingEnabled = true;
            lbxPlayer.ItemHeight = 20;
            lbxPlayer.Location = new Point(6, 27);
            lbxPlayer.Name = "lbxPlayer";
            lbxPlayer.Size = new Size(248, 144);
            lbxPlayer.TabIndex = 7;
            // 
            // btnConnect
            // 
            btnConnect.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConnect.Location = new Point(524, 309);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(110, 30);
            btnConnect.TabIndex = 7;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisc
            // 
            btnDisc.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDisc.Location = new Point(679, 309);
            btnDisc.Name = "btnDisc";
            btnDisc.Size = new Size(110, 30);
            btnDisc.TabIndex = 8;
            btnDisc.Text = "Disconnect";
            btnDisc.UseVisualStyleBackColor = true;
            btnDisc.Click += btnDisc_Click;
            // 
            // gbxClientStatus
            // 
            gbxClientStatus.Controls.Add(lbxStatus);
            gbxClientStatus.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbxClientStatus.Location = new Point(524, 354);
            gbxClientStatus.Name = "gbxClientStatus";
            gbxClientStatus.Size = new Size(266, 95);
            gbxClientStatus.TabIndex = 9;
            gbxClientStatus.TabStop = false;
            gbxClientStatus.Text = "Client Status";
            // 
            // lbxStatus
            // 
            lbxStatus.FormattingEnabled = true;
            lbxStatus.ItemHeight = 20;
            lbxStatus.Location = new Point(6, 27);
            lbxStatus.Name = "lbxStatus";
            lbxStatus.Size = new Size(254, 64);
            lbxStatus.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 420);
            panel1.TabIndex = 10;
            panel1.Visible = false;
            // 
            // RefreshTimer
            // 
            RefreshTimer.Tick += RefreshTimer_Tick;
            // 
            // tbxIP
            // 
            tbxIP.Location = new Point(689, 16);
            tbxIP.Name = "tbxIP";
            tbxIP.Size = new Size(100, 23);
            tbxIP.TabIndex = 11;
            // 
            // tbxPort
            // 
            tbxPort.Location = new Point(689, 51);
            tbxPort.Name = "tbxPort";
            tbxPort.Size = new Size(100, 23);
            tbxPort.TabIndex = 12;
            // 
            // tbxName
            // 
            tbxName.Location = new Point(689, 86);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(100, 23);
            tbxName.TabIndex = 13;
            tbxName.Text = "NTPUCSIE";
            // 
            // TCPClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 461);
            Controls.Add(tbxName);
            Controls.Add(tbxPort);
            Controls.Add(tbxIP);
            Controls.Add(panel1);
            Controls.Add(gbxClientStatus);
            Controls.Add(btnDisc);
            Controls.Add(btnConnect);
            Controls.Add(gbxPlayer);
            Controls.Add(lbName);
            Controls.Add(lbPort);
            Controls.Add(lbIP);
            Name = "TCPClient";
            Text = "Client";
            Paint += TCPClient_Paint;
            KeyDown += TCPClient_KeyDown;
            gbxPlayer.ResumeLayout(false);
            gbxClientStatus.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbIP;
        private Label lbPort;
        private Label lbName;
        private GroupBox gbxPlayer;
        private ListBox lbxPlayer;
        private Button btnConnect;
        private Button btnDisc;
        private GroupBox gbxClientStatus;
        private ListBox lbxStatus;
        private Panel panel1;
        private System.Windows.Forms.Timer RefreshTimer;
        private TextBox tbxIP;
        private TextBox tbxPort;
        private TextBox tbxName;
    }
}