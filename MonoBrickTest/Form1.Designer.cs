namespace MonoBrickTest {
    partial class Form1 {
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
            this.lbxInbox = new System.Windows.Forms.ListBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSerial = new System.Windows.Forms.TextBox();
            this.btnSendByte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxInbox
            // 
            this.lbxInbox.FormattingEnabled = true;
            this.lbxInbox.ItemHeight = 16;
            this.lbxInbox.Location = new System.Drawing.Point(12, 12);
            this.lbxInbox.Name = "lbxInbox";
            this.lbxInbox.Size = new System.Drawing.Size(651, 100);
            this.lbxInbox.TabIndex = 0;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 139);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(170, 22);
            this.tbName.TabIndex = 1;
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(330, 139);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(140, 22);
            this.tbIP.TabIndex = 2;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(476, 139);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(60, 22);
            this.tbPort.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "IP Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Serial";
            // 
            // tbSerial
            // 
            this.tbSerial.Location = new System.Drawing.Point(188, 139);
            this.tbSerial.Name = "tbSerial";
            this.tbSerial.Size = new System.Drawing.Size(136, 22);
            this.tbSerial.TabIndex = 8;
            // 
            // btnSendByte
            // 
            this.btnSendByte.Location = new System.Drawing.Point(542, 139);
            this.btnSendByte.Name = "btnSendByte";
            this.btnSendByte.Size = new System.Drawing.Size(121, 23);
            this.btnSendByte.TabIndex = 9;
            this.btnSendByte.Text = "Send Byte";
            this.btnSendByte.UseVisualStyleBackColor = true;
            this.btnSendByte.Click += new System.EventHandler(this.btnSendByte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 497);
            this.Controls.Add(this.btnSendByte);
            this.Controls.Add(this.tbSerial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbxInbox);
            this.Name = "Form1";
            this.Text = "x";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxInbox;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSerial;
        private System.Windows.Forms.Button btnSendByte;
    }
}

