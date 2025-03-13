namespace Server
{
    partial class TCPServer
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
            IP_Address = new Label();
            Port_Number = new Label();
            btnStart = new Button();
            btnClose = new Button();
            gbxServerStatus = new GroupBox();
            lbxServerStatus = new ListBox();
            lbxConnected = new ListBox();
            gbxClientStatus = new GroupBox();
            tbxIP = new TextBox();
            tbxPort = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            gbxServerStatus.SuspendLayout();
            gbxClientStatus.SuspendLayout();
            SuspendLayout();
            // 
            // IP_Address
            // 
            IP_Address.AutoSize = true;
            IP_Address.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            IP_Address.Location = new Point(18, 30);
            IP_Address.Name = "IP_Address";
            IP_Address.Size = new Size(91, 20);
            IP_Address.TabIndex = 3;
            IP_Address.Text = "IP Address";
            // 
            // Port_Number
            // 
            Port_Number.AutoSize = true;
            Port_Number.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Port_Number.Location = new Point(18, 78);
            Port_Number.Name = "Port_Number";
            Port_Number.Size = new Size(108, 20);
            Port_Number.TabIndex = 4;
            Port_Number.Text = "Port Number";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(285, 27);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(120, 30);
            btnStart.TabIndex = 7;
            btnStart.Text = "Start Server";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(285, 68);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 30);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close Server";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // gbxServerStatus
            // 
            gbxServerStatus.Controls.Add(lbxServerStatus);
            gbxServerStatus.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbxServerStatus.Location = new Point(18, 123);
            gbxServerStatus.Name = "gbxServerStatus";
            gbxServerStatus.Size = new Size(404, 120);
            gbxServerStatus.TabIndex = 9;
            gbxServerStatus.TabStop = false;
            gbxServerStatus.Text = "Server Status";
            // 
            // lbxServerStatus
            // 
            lbxServerStatus.FormattingEnabled = true;
            lbxServerStatus.ItemHeight = 20;
            lbxServerStatus.Location = new Point(6, 27);
            lbxServerStatus.Name = "lbxServerStatus";
            lbxServerStatus.Size = new Size(392, 84);
            lbxServerStatus.TabIndex = 0;
            // 
            // lbxConnected
            // 
            lbxConnected.FormattingEnabled = true;
            lbxConnected.ItemHeight = 20;
            lbxConnected.Location = new Point(6, 27);
            lbxConnected.Name = "lbxConnected";
            lbxConnected.Size = new Size(392, 84);
            lbxConnected.TabIndex = 1;
            // 
            // gbxClientStatus
            // 
            gbxClientStatus.Controls.Add(lbxConnected);
            gbxClientStatus.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbxClientStatus.Location = new Point(18, 270);
            gbxClientStatus.Name = "gbxClientStatus";
            gbxClientStatus.Size = new Size(404, 120);
            gbxClientStatus.TabIndex = 10;
            gbxClientStatus.TabStop = false;
            gbxClientStatus.Text = "Client List";
            // 
            // tbxIP
            // 
            tbxIP.Location = new Point(132, 27);
            tbxIP.Name = "tbxIP";
            tbxIP.Size = new Size(100, 23);
            tbxIP.TabIndex = 11;
            // 
            // tbxPort
            // 
            tbxPort.Location = new Point(132, 75);
            tbxPort.Name = "tbxPort";
            tbxPort.Size = new Size(100, 23);
            tbxPort.TabIndex = 12;
            tbxPort.Text = "666";
            // 
            // TCPServer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 411);
            Controls.Add(tbxPort);
            Controls.Add(tbxIP);
            Controls.Add(gbxClientStatus);
            Controls.Add(gbxServerStatus);
            Controls.Add(btnClose);
            Controls.Add(btnStart);
            Controls.Add(Port_Number);
            Controls.Add(IP_Address);
            Name = "TCPServer";
            Text = "Server";
            gbxServerStatus.ResumeLayout(false);
            gbxClientStatus.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label IP_Address;
        private Label Port_Number;
        private Button btnStart;
        private Button btnClose;
        private GroupBox gbxServerStatus;
        private ListBox lbxServerStatus;
        private GroupBox gbxClientStatus;
        private ListBox lbxConnected;
        private TextBox tbxIP;
        private TextBox tbxPort;
        private System.Windows.Forms.Timer timer1;
    }
}