namespace Terminal
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.RadioButton rdbHand1;
            this.cbxCom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.cmsCom = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miReScan = new System.Windows.Forms.ToolStripMenuItem();
            this.UART = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb600 = new System.Windows.Forms.RadioButton();
            this.rdb1200 = new System.Windows.Forms.RadioButton();
            this.rdb2400 = new System.Windows.Forms.RadioButton();
            this.rdb4800 = new System.Windows.Forms.RadioButton();
            this.rdb9600 = new System.Windows.Forms.RadioButton();
            this.rdb14400 = new System.Windows.Forms.RadioButton();
            this.rdb19200 = new System.Windows.Forms.RadioButton();
            this.rdb28800 = new System.Windows.Forms.RadioButton();
            this.rdb38400 = new System.Windows.Forms.RadioButton();
            this.rdb56000 = new System.Windows.Forms.RadioButton();
            this.rdb57600 = new System.Windows.Forms.RadioButton();
            this.rdb115200 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb8 = new System.Windows.Forms.RadioButton();
            this.rdb7 = new System.Windows.Forms.RadioButton();
            this.rdb6 = new System.Windows.Forms.RadioButton();
            this.rdb5 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb15 = new System.Windows.Forms.RadioButton();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbHand3 = new System.Windows.Forms.RadioButton();
            this.rdbHand2 = new System.Windows.Forms.RadioButton();
            this.rdbHand4 = new System.Windows.Forms.RadioButton();
            this.rdbHand5 = new System.Windows.Forms.RadioButton();
            this.txbReceived = new System.Windows.Forms.TextBox();
            this.txbSending = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            rdbHand1 = new System.Windows.Forms.RadioButton();
            this.cmsCom.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxCom
            // 
            this.cbxCom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCom.FormattingEnabled = true;
            this.cbxCom.Location = new System.Drawing.Point(206, 30);
            this.cbxCom.Name = "cbxCom";
            this.cbxCom.Size = new System.Drawing.Size(223, 30);
            this.cbxCom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(125, 85);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 33);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            //this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(307, 85);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(122, 33);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "DisConnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // cmsCom
            // 
            this.cmsCom.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsCom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miReScan});
            this.cmsCom.Name = "cmsCom";
            this.cmsCom.Size = new System.Drawing.Size(127, 28);
            // 
            // miReScan
            // 
            this.miReScan.Name = "miReScan";
            this.miReScan.Size = new System.Drawing.Size(126, 24);
            this.miReScan.Text = "ReScan";
            this.miReScan.Click += new System.EventHandler(this.miReScan_Click);
            // 
            // UART
            // 
            this.UART.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.UART_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb115200);
            this.groupBox1.Controls.Add(this.rdb57600);
            this.groupBox1.Controls.Add(this.rdb56000);
            this.groupBox1.Controls.Add(this.rdb38400);
            this.groupBox1.Controls.Add(this.rdb28800);
            this.groupBox1.Controls.Add(this.rdb19200);
            this.groupBox1.Controls.Add(this.rdb14400);
            this.groupBox1.Controls.Add(this.rdb9600);
            this.groupBox1.Controls.Add(this.rdb4800);
            this.groupBox1.Controls.Add(this.rdb2400);
            this.groupBox1.Controls.Add(this.rdb1200);
            this.groupBox1.Controls.Add(this.rdb600);
            this.groupBox1.Location = new System.Drawing.Point(504, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 153);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Baud Rate";
            // 
            // rdb600
            // 
            this.rdb600.AutoSize = true;
            this.rdb600.Location = new System.Drawing.Point(6, 21);
            this.rdb600.Name = "rdb600";
            this.rdb600.Size = new System.Drawing.Size(53, 21);
            this.rdb600.TabIndex = 0;
            this.rdb600.Text = "600";
            this.rdb600.UseVisualStyleBackColor = true;
            // 
            // rdb1200
            // 
            this.rdb1200.AutoSize = true;
            this.rdb1200.Location = new System.Drawing.Point(6, 55);
            this.rdb1200.Name = "rdb1200";
            this.rdb1200.Size = new System.Drawing.Size(61, 21);
            this.rdb1200.TabIndex = 1;
            this.rdb1200.Text = "1200";
            this.rdb1200.UseVisualStyleBackColor = true;
            // 
            // rdb2400
            // 
            this.rdb2400.AutoSize = true;
            this.rdb2400.Location = new System.Drawing.Point(6, 91);
            this.rdb2400.Name = "rdb2400";
            this.rdb2400.Size = new System.Drawing.Size(61, 21);
            this.rdb2400.TabIndex = 2;
            this.rdb2400.Text = "2400";
            this.rdb2400.UseVisualStyleBackColor = true;
            // 
            // rdb4800
            // 
            this.rdb4800.AutoSize = true;
            this.rdb4800.Location = new System.Drawing.Point(6, 126);
            this.rdb4800.Name = "rdb4800";
            this.rdb4800.Size = new System.Drawing.Size(61, 21);
            this.rdb4800.TabIndex = 3;
            this.rdb4800.Text = "4800";
            this.rdb4800.UseVisualStyleBackColor = true;
            // 
            // rdb9600
            // 
            this.rdb9600.AutoSize = true;
            this.rdb9600.Checked = true;
            this.rdb9600.Location = new System.Drawing.Point(122, 21);
            this.rdb9600.Name = "rdb9600";
            this.rdb9600.Size = new System.Drawing.Size(61, 21);
            this.rdb9600.TabIndex = 4;
            this.rdb9600.TabStop = true;
            this.rdb9600.Text = "9600";
            this.rdb9600.UseVisualStyleBackColor = true;
            // 
            // rdb14400
            // 
            this.rdb14400.AutoSize = true;
            this.rdb14400.Location = new System.Drawing.Point(122, 61);
            this.rdb14400.Name = "rdb14400";
            this.rdb14400.Size = new System.Drawing.Size(69, 21);
            this.rdb14400.TabIndex = 5;
            this.rdb14400.Text = "14400";
            this.rdb14400.UseVisualStyleBackColor = true;
            // 
            // rdb19200
            // 
            this.rdb19200.AutoSize = true;
            this.rdb19200.Location = new System.Drawing.Point(122, 91);
            this.rdb19200.Name = "rdb19200";
            this.rdb19200.Size = new System.Drawing.Size(69, 21);
            this.rdb19200.TabIndex = 6;
            this.rdb19200.Text = "19200";
            this.rdb19200.UseVisualStyleBackColor = true;
            // 
            // rdb28800
            // 
            this.rdb28800.AutoSize = true;
            this.rdb28800.Location = new System.Drawing.Point(122, 126);
            this.rdb28800.Name = "rdb28800";
            this.rdb28800.Size = new System.Drawing.Size(69, 21);
            this.rdb28800.TabIndex = 7;
            this.rdb28800.Text = "28800";
            this.rdb28800.UseVisualStyleBackColor = true;
            // 
            // rdb38400
            // 
            this.rdb38400.AutoSize = true;
            this.rdb38400.Location = new System.Drawing.Point(230, 21);
            this.rdb38400.Name = "rdb38400";
            this.rdb38400.Size = new System.Drawing.Size(69, 21);
            this.rdb38400.TabIndex = 8;
            this.rdb38400.Text = "38400";
            this.rdb38400.UseVisualStyleBackColor = true;
            // 
            // rdb56000
            // 
            this.rdb56000.AutoSize = true;
            this.rdb56000.Location = new System.Drawing.Point(230, 61);
            this.rdb56000.Name = "rdb56000";
            this.rdb56000.Size = new System.Drawing.Size(69, 21);
            this.rdb56000.TabIndex = 5;
            this.rdb56000.Text = "56000";
            this.rdb56000.UseVisualStyleBackColor = true;
            // 
            // rdb57600
            // 
            this.rdb57600.AutoSize = true;
            this.rdb57600.Location = new System.Drawing.Point(228, 91);
            this.rdb57600.Name = "rdb57600";
            this.rdb57600.Size = new System.Drawing.Size(69, 21);
            this.rdb57600.TabIndex = 5;
            this.rdb57600.Text = "57600";
            this.rdb57600.UseVisualStyleBackColor = true;
            // 
            // rdb115200
            // 
            this.rdb115200.AutoSize = true;
            this.rdb115200.Location = new System.Drawing.Point(228, 126);
            this.rdb115200.Name = "rdb115200";
            this.rdb115200.Size = new System.Drawing.Size(77, 21);
            this.rdb115200.TabIndex = 5;
            this.rdb115200.Text = "115200";
            this.rdb115200.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdb8);
            this.groupBox2.Controls.Add(this.rdb7);
            this.groupBox2.Controls.Add(this.rdb6);
            this.groupBox2.Controls.Add(this.rdb5);
            this.groupBox2.Location = new System.Drawing.Point(864, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(94, 153);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DataBits";
            // 
            // rdb8
            // 
            this.rdb8.AutoSize = true;
            this.rdb8.Checked = true;
            this.rdb8.Location = new System.Drawing.Point(6, 126);
            this.rdb8.Name = "rdb8";
            this.rdb8.Size = new System.Drawing.Size(37, 21);
            this.rdb8.TabIndex = 3;
            this.rdb8.TabStop = true;
            this.rdb8.Text = "8";
            this.rdb8.UseVisualStyleBackColor = true;
            // 
            // rdb7
            // 
            this.rdb7.AutoSize = true;
            this.rdb7.Location = new System.Drawing.Point(6, 91);
            this.rdb7.Name = "rdb7";
            this.rdb7.Size = new System.Drawing.Size(37, 21);
            this.rdb7.TabIndex = 2;
            this.rdb7.Text = "7";
            this.rdb7.UseVisualStyleBackColor = true;
            // 
            // rdb6
            // 
            this.rdb6.AutoSize = true;
            this.rdb6.Location = new System.Drawing.Point(6, 55);
            this.rdb6.Name = "rdb6";
            this.rdb6.Size = new System.Drawing.Size(37, 21);
            this.rdb6.TabIndex = 1;
            this.rdb6.Text = "6";
            this.rdb6.UseVisualStyleBackColor = true;
            // 
            // rdb5
            // 
            this.rdb5.AutoSize = true;
            this.rdb5.Location = new System.Drawing.Point(6, 21);
            this.rdb5.Name = "rdb5";
            this.rdb5.Size = new System.Drawing.Size(37, 21);
            this.rdb5.TabIndex = 0;
            this.rdb5.Text = "5";
            this.rdb5.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdb2);
            this.groupBox3.Controls.Add(this.rdb15);
            this.groupBox3.Controls.Add(this.rdb1);
            this.groupBox3.Location = new System.Drawing.Point(988, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(94, 153);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stop bits";
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Checked = true;
            this.rdb2.Location = new System.Drawing.Point(6, 91);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(37, 21);
            this.rdb2.TabIndex = 2;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "2";
            this.rdb2.UseVisualStyleBackColor = true;
            // 
            // rdb15
            // 
            this.rdb15.AutoSize = true;
            this.rdb15.Location = new System.Drawing.Point(6, 55);
            this.rdb15.Name = "rdb15";
            this.rdb15.Size = new System.Drawing.Size(49, 21);
            this.rdb15.TabIndex = 1;
            this.rdb15.Text = "1.5";
            this.rdb15.UseVisualStyleBackColor = true;
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Location = new System.Drawing.Point(6, 21);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(37, 21);
            this.rdb1.TabIndex = 0;
            this.rdb1.Text = "1";
            this.rdb1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdbHand5);
            this.groupBox4.Controls.Add(this.rdbHand4);
            this.groupBox4.Controls.Add(this.rdbHand3);
            this.groupBox4.Controls.Add(this.rdbHand2);
            this.groupBox4.Controls.Add(rdbHand1);
            this.groupBox4.Location = new System.Drawing.Point(1136, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(173, 182);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Handshaking";
            // 
            // rdbHand3
            // 
            this.rdbHand3.AutoSize = true;
            this.rdbHand3.Location = new System.Drawing.Point(6, 91);
            this.rdbHand3.Name = "rdbHand3";
            this.rdbHand3.Size = new System.Drawing.Size(99, 21);
            this.rdbHand3.TabIndex = 2;
            this.rdbHand3.Text = "XON/XOFF";
            this.rdbHand3.UseVisualStyleBackColor = true;
            // 
            // rdbHand2
            // 
            this.rdbHand2.AutoSize = true;
            this.rdbHand2.Location = new System.Drawing.Point(6, 55);
            this.rdbHand2.Name = "rdbHand2";
            this.rdbHand2.Size = new System.Drawing.Size(88, 21);
            this.rdbHand2.TabIndex = 1;
            this.rdbHand2.Text = "RTS/CTS";
            this.rdbHand2.UseVisualStyleBackColor = true;
            // 
            // rdbHand1
            // 
            rdbHand1.AutoSize = true;
            rdbHand1.Location = new System.Drawing.Point(6, 21);
            rdbHand1.Name = "rdbHand1";
            rdbHand1.Size = new System.Drawing.Size(63, 21);
            rdbHand1.TabIndex = 0;
            rdbHand1.Text = "None";
            rdbHand1.UseVisualStyleBackColor = true;
            // 
            // rdbHand4
            // 
            this.rdbHand4.AutoSize = true;
            this.rdbHand4.Checked = true;
            this.rdbHand4.Location = new System.Drawing.Point(6, 118);
            this.rdbHand4.Name = "rdbHand4";
            this.rdbHand4.Size = new System.Drawing.Size(174, 21);
            this.rdbHand4.TabIndex = 3;
            this.rdbHand4.TabStop = true;
            this.rdbHand4.Text = "RTS/CTS + XON/XOFF";
            this.rdbHand4.UseVisualStyleBackColor = true;
            // 
            // rdbHand5
            // 
            this.rdbHand5.AutoSize = true;
            this.rdbHand5.Location = new System.Drawing.Point(6, 145);
            this.rdbHand5.Name = "rdbHand5";
            this.rdbHand5.Size = new System.Drawing.Size(99, 21);
            this.rdbHand5.TabIndex = 4;
            this.rdbHand5.Text = "RTS on TX";
            this.rdbHand5.UseVisualStyleBackColor = true;
            // 
            // txbReceived
            // 
            this.txbReceived.Location = new System.Drawing.Point(30, 218);
            this.txbReceived.Multiline = true;
            this.txbReceived.Name = "txbReceived";
            this.txbReceived.Size = new System.Drawing.Size(1279, 361);
            this.txbReceived.TabIndex = 12;
            // 
            // txbSending
            // 
            this.txbSending.Location = new System.Drawing.Point(30, 610);
            this.txbSending.Multiline = true;
            this.txbSending.Name = "txbSending";
            this.txbSending.Size = new System.Drawing.Size(1211, 96);
            this.txbSending.TabIndex = 13;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(1241, 610);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 33);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "Sending";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 705);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txbSending);
            this.Controls.Add(this.txbReceived);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCom);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.cmsCom.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        public System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.ContextMenuStrip cmsCom;
        private System.Windows.Forms.ToolStripMenuItem miReScan;
        private System.IO.Ports.SerialPort UART;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb115200;
        private System.Windows.Forms.RadioButton rdb57600;
        private System.Windows.Forms.RadioButton rdb56000;
        private System.Windows.Forms.RadioButton rdb38400;
        private System.Windows.Forms.RadioButton rdb28800;
        private System.Windows.Forms.RadioButton rdb19200;
        private System.Windows.Forms.RadioButton rdb14400;
        private System.Windows.Forms.RadioButton rdb9600;
        private System.Windows.Forms.RadioButton rdb4800;
        private System.Windows.Forms.RadioButton rdb2400;
        private System.Windows.Forms.RadioButton rdb1200;
        private System.Windows.Forms.RadioButton rdb600;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdb8;
        private System.Windows.Forms.RadioButton rdb7;
        private System.Windows.Forms.RadioButton rdb6;
        private System.Windows.Forms.RadioButton rdb5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb15;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdbHand5;
        private System.Windows.Forms.RadioButton rdbHand4;
        private System.Windows.Forms.RadioButton rdbHand3;
        private System.Windows.Forms.RadioButton rdbHand2;
        private System.Windows.Forms.TextBox txbReceived;
        private System.Windows.Forms.TextBox txbSending;
        private System.Windows.Forms.Button btnSend;
    }
}

