namespace Arduino_Test {
    partial class ArduinoTestForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.cbbComPorts = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.pbConnected = new System.Windows.Forms.ProgressBar();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lbCom = new System.Windows.Forms.Label();
            this.tmInbox = new System.Windows.Forms.Timer(this.components);
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.cbbBaud = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(404, 294);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMessage.Location = new System.Drawing.Point(65, 294);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(333, 22);
            this.tbMessage.TabIndex = 5;
            // 
            // cbbComPorts
            // 
            this.cbbComPorts.FormattingEnabled = true;
            this.cbbComPorts.Location = new System.Drawing.Point(12, 12);
            this.cbbComPorts.Name = "cbbComPorts";
            this.cbbComPorts.Size = new System.Drawing.Size(99, 24);
            this.cbbComPorts.TabIndex = 1;
            this.cbbComPorts.Text = "Pick Port";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(200, 13);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // pbConnected
            // 
            this.pbConnected.Location = new System.Drawing.Point(382, 13);
            this.pbConnected.Name = "pbConnected";
            this.pbConnected.Size = new System.Drawing.Size(98, 23);
            this.pbConnected.TabIndex = 7;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(281, 13);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(95, 23);
            this.btnDisconnect.TabIndex = 7;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lbCom
            // 
            this.lbCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCom.AutoSize = true;
            this.lbCom.Location = new System.Drawing.Point(12, 297);
            this.lbCom.Name = "lbCom";
            this.lbCom.Size = new System.Drawing.Size(47, 17);
            this.lbCom.TabIndex = 9;
            this.lbCom.Text = "COM1";
            // 
            // tmInbox
            // 
            this.tmInbox.Tick += new System.EventHandler(this.tmInbox_Tick);
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.Location = new System.Drawing.Point(12, 42);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(468, 246);
            this.rtbLog.TabIndex = 10;
            this.rtbLog.Text = "";
            this.rtbLog.TextChanged += new System.EventHandler(this.rtbLog_TextChanged);
            // 
            // cbbBaud
            // 
            this.cbbBaud.FormattingEnabled = true;
            this.cbbBaud.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.cbbBaud.Location = new System.Drawing.Point(117, 12);
            this.cbbBaud.Name = "cbbBaud";
            this.cbbBaud.Size = new System.Drawing.Size(77, 24);
            this.cbbBaud.TabIndex = 2;
            this.cbbBaud.Text = "9600";
            // 
            // ArduinoTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 329);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.lbCom);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.pbConnected);
            this.Controls.Add(this.cbbBaud);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cbbComPorts);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.btnSend);
            this.Name = "ArduinoTestForm";
            this.Text = "Arduino Test";
            this.Load += new System.EventHandler(this.ArduinoTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.ComboBox cbbComPorts;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ProgressBar pbConnected;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label lbCom;
        private System.Windows.Forms.Timer tmInbox;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.ComboBox cbbBaud;
    }
}

