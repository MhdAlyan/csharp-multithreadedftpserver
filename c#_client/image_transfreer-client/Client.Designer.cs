namespace Files_transfreer_client
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextBox_Receive_Text_Data = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Receive = new System.Windows.Forms.TextBox();
            this.Button_Save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_Send = new System.Windows.Forms.TextBox();
            this.Button_Send = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel_Server_ingo = new System.Windows.Forms.ToolStripStatusLabel();
            this.TextBox_serverIp = new System.Windows.Forms.TextBox();
            this.TextBox_portNumber = new System.Windows.Forms.TextBox();
            this.label_ServerIP = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Button_Disconnect = new System.Windows.Forms.Button();
            this.Button_Connect = new System.Windows.Forms.Button();
            this.label_port = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TextBox_Remote_Client_IP = new System.Windows.Forms.TextBox();
            this.label_Remote_Client_IP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_Input_Send_to_Client = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBox_Send_To_Client = new System.Windows.Forms.TextBox();
            this.Button_Send_2_Client = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextBox_Receive_Text_Data);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_Receive);
            this.groupBox2.Controls.Add(this.Button_Save);
            this.groupBox2.Location = new System.Drawing.Point(308, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 374);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receiving";
            // 
            // TextBox_Receive_Text_Data
            // 
            this.TextBox_Receive_Text_Data.Location = new System.Drawing.Point(11, 75);
            this.TextBox_Receive_Text_Data.Multiline = true;
            this.TextBox_Receive_Text_Data.Name = "TextBox_Receive_Text_Data";
            this.TextBox_Receive_Text_Data.ReadOnly = true;
            this.TextBox_Receive_Text_Data.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox_Receive_Text_Data.Size = new System.Drawing.Size(272, 285);
            this.TextBox_Receive_Text_Data.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Size of File You are Received From Server";
            // 
            // textBox_Receive
            // 
            this.textBox_Receive.Location = new System.Drawing.Point(90, 38);
            this.textBox_Receive.Name = "textBox_Receive";
            this.textBox_Receive.ReadOnly = true;
            this.textBox_Receive.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Receive.Size = new System.Drawing.Size(193, 20);
            this.textBox_Receive.TabIndex = 7;
            // 
            // Button_Save
            // 
            this.Button_Save.Location = new System.Drawing.Point(6, 35);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(75, 23);
            this.Button_Save.TabIndex = 6;
            this.Button_Save.Text = "save File";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TextBox_Input);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextBox_Send);
            this.groupBox1.Controls.Add(this.Button_Send);
            this.groupBox1.Location = new System.Drawing.Point(12, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 98);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sending  To The Server";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Send Text Data";
            // 
            // TextBox_Input
            // 
            this.TextBox_Input.Location = new System.Drawing.Point(100, 61);
            this.TextBox_Input.Name = "TextBox_Input";
            this.TextBox_Input.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox_Input.Size = new System.Drawing.Size(162, 20);
            this.TextBox_Input.TabIndex = 16;
            this.TextBox_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_input_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Size of File You are Sent";
            // 
            // TextBox_Send
            // 
            this.TextBox_Send.Location = new System.Drawing.Point(101, 35);
            this.TextBox_Send.Name = "TextBox_Send";
            this.TextBox_Send.ReadOnly = true;
            this.TextBox_Send.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox_Send.Size = new System.Drawing.Size(161, 20);
            this.TextBox_Send.TabIndex = 8;
            // 
            // Button_Send
            // 
            this.Button_Send.Location = new System.Drawing.Point(10, 31);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(81, 23);
            this.Button_Send.TabIndex = 7;
            this.Button_Send.Text = "Send File";
            this.Button_Send.UseVisualStyleBackColor = true;
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel_Server_ingo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(667, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripStatusLabel_Server_ingo
            // 
            this.ToolStripStatusLabel_Server_ingo.Name = "ToolStripStatusLabel_Server_ingo";
            this.ToolStripStatusLabel_Server_ingo.Size = new System.Drawing.Size(10, 17);
            this.ToolStripStatusLabel_Server_ingo.Text = " ";
            this.ToolStripStatusLabel_Server_ingo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // TextBox_serverIp
            // 
            this.TextBox_serverIp.Location = new System.Drawing.Point(94, 28);
            this.TextBox_serverIp.Name = "TextBox_serverIp";
            this.TextBox_serverIp.Size = new System.Drawing.Size(152, 20);
            this.TextBox_serverIp.TabIndex = 14;
            this.TextBox_serverIp.Text = "localhost";
            // 
            // TextBox_portNumber
            // 
            this.TextBox_portNumber.Location = new System.Drawing.Point(94, 67);
            this.TextBox_portNumber.Name = "TextBox_portNumber";
            this.TextBox_portNumber.Size = new System.Drawing.Size(152, 20);
            this.TextBox_portNumber.TabIndex = 15;
            this.TextBox_portNumber.Text = "5000";
            // 
            // label_ServerIP
            // 
            this.label_ServerIP.AutoSize = true;
            this.label_ServerIP.Location = new System.Drawing.Point(23, 31);
            this.label_ServerIP.Name = "label_ServerIP";
            this.label_ServerIP.Size = new System.Drawing.Size(52, 13);
            this.label_ServerIP.TabIndex = 16;
            this.label_ServerIP.Text = "Server Ip";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Button_Disconnect);
            this.groupBox3.Controls.Add(this.Button_Connect);
            this.groupBox3.Controls.Add(this.label_port);
            this.groupBox3.Controls.Add(this.label_ServerIP);
            this.groupBox3.Controls.Add(this.TextBox_portNumber);
            this.groupBox3.Controls.Add(this.TextBox_serverIp);
            this.groupBox3.Location = new System.Drawing.Point(18, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 137);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Setting";
            // 
            // Button_Disconnect
            // 
            this.Button_Disconnect.Location = new System.Drawing.Point(155, 98);
            this.Button_Disconnect.Name = "Button_Disconnect";
            this.Button_Disconnect.Size = new System.Drawing.Size(91, 23);
            this.Button_Disconnect.TabIndex = 19;
            this.Button_Disconnect.Text = "Disconnect";
            this.Button_Disconnect.UseVisualStyleBackColor = true;
            this.Button_Disconnect.Click += new System.EventHandler(this.Button_Disconnect_Click);
            // 
            // Button_Connect
            // 
            this.Button_Connect.Location = new System.Drawing.Point(26, 98);
            this.Button_Connect.Name = "Button_Connect";
            this.Button_Connect.Size = new System.Drawing.Size(101, 23);
            this.Button_Connect.TabIndex = 18;
            this.Button_Connect.Text = "Connect";
            this.Button_Connect.UseVisualStyleBackColor = true;
            this.Button_Connect.Click += new System.EventHandler(this.Button_Connect_Click);
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Location = new System.Drawing.Point(23, 67);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(62, 13);
            this.label_port.TabIndex = 17;
            this.label_port.Text = "Server Port";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TextBox_Remote_Client_IP);
            this.groupBox4.Controls.Add(this.label_Remote_Client_IP);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.TextBox_Input_Send_to_Client);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.TextBox_Send_To_Client);
            this.groupBox4.Controls.Add(this.Button_Send_2_Client);
            this.groupBox4.ForeColor = System.Drawing.Color.Red;
            this.groupBox4.Location = new System.Drawing.Point(12, 259);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(279, 127);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sending To Selected Client";
            // 
            // TextBox_Remote_Client_IP
            // 
            this.TextBox_Remote_Client_IP.Location = new System.Drawing.Point(113, 22);
            this.TextBox_Remote_Client_IP.Name = "TextBox_Remote_Client_IP";
            this.TextBox_Remote_Client_IP.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox_Remote_Client_IP.Size = new System.Drawing.Size(147, 20);
            this.TextBox_Remote_Client_IP.TabIndex = 20;
            // 
            // label_Remote_Client_IP
            // 
            this.label_Remote_Client_IP.AutoSize = true;
            this.label_Remote_Client_IP.Location = new System.Drawing.Point(8, 27);
            this.label_Remote_Client_IP.Name = "label_Remote_Client_IP";
            this.label_Remote_Client_IP.Size = new System.Drawing.Size(87, 13);
            this.label_Remote_Client_IP.TabIndex = 19;
            this.label_Remote_Client_IP.Text = "Remote Client IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Send Text Data";
            // 
            // TextBox_Input_Send_to_Client
            // 
            this.TextBox_Input_Send_to_Client.Location = new System.Drawing.Point(113, 94);
            this.TextBox_Input_Send_to_Client.Name = "TextBox_Input_Send_to_Client";
            this.TextBox_Input_Send_to_Client.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox_Input_Send_to_Client.Size = new System.Drawing.Size(162, 20);
            this.TextBox_Input_Send_to_Client.TabIndex = 16;
            this.TextBox_Input_Send_to_Client.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_Input_Send_to_Client_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Size of File You are Sent";
            // 
            // TextBox_Send_To_Client
            // 
            this.TextBox_Send_To_Client.Location = new System.Drawing.Point(113, 68);
            this.TextBox_Send_To_Client.Name = "TextBox_Send_To_Client";
            this.TextBox_Send_To_Client.ReadOnly = true;
            this.TextBox_Send_To_Client.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox_Send_To_Client.Size = new System.Drawing.Size(161, 20);
            this.TextBox_Send_To_Client.TabIndex = 8;
            // 
            // Button_Send_2_Client
            // 
            this.Button_Send_2_Client.Location = new System.Drawing.Point(4, 65);
            this.Button_Send_2_Client.Name = "Button_Send_2_Client";
            this.Button_Send_2_Client.Size = new System.Drawing.Size(104, 23);
            this.Button_Send_2_Client.TabIndex = 7;
            this.Button_Send_2_Client.Text = "Send File To Client";
            this.Button_Send_2_Client.UseVisualStyleBackColor = true;
            this.Button_Send_2_Client.Click += new System.EventHandler(this.Button_Send_2_Client_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 421);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Client";
            this.Text = "client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Receive;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_Send;
        private System.Windows.Forms.Button Button_Send;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel_Server_ingo;
        private System.Windows.Forms.TextBox TextBox_Receive_Text_Data;
        private System.Windows.Forms.TextBox TextBox_Input;
        private System.Windows.Forms.TextBox TextBox_serverIp;
        private System.Windows.Forms.TextBox TextBox_portNumber;
        private System.Windows.Forms.Label label_ServerIP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_Disconnect;
        private System.Windows.Forms.Button Button_Connect;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox_Input_Send_to_Client;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBox_Send_To_Client;
        private System.Windows.Forms.Button Button_Send_2_Client;
        private System.Windows.Forms.TextBox TextBox_Remote_Client_IP;
        private System.Windows.Forms.Label label_Remote_Client_IP;
    }
}

