namespace BouncerController {
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCurrentTilt = new System.Windows.Forms.TextBox();
            this.btnResetTilt = new System.Windows.Forms.Button();
            this.btnRandomTilt = new System.Windows.Forms.Button();
            this.btnDefaultTilt = new System.Windows.Forms.Button();
            this.trbTilt = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnApplyCustomTilt = new System.Windows.Forms.Button();
            this.tbCustomTilt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbA1 = new System.Windows.Forms.CheckBox();
            this.cbB1 = new System.Windows.Forms.CheckBox();
            this.cbA2 = new System.Windows.Forms.CheckBox();
            this.cbA3 = new System.Windows.Forms.CheckBox();
            this.cbB4 = new System.Windows.Forms.CheckBox();
            this.cbB3 = new System.Windows.Forms.CheckBox();
            this.cbB2 = new System.Windows.Forms.CheckBox();
            this.cbA4 = new System.Windows.Forms.CheckBox();
            this.pnA4 = new System.Windows.Forms.Panel();
            this.pnA3 = new System.Windows.Forms.Panel();
            this.pnA2 = new System.Windows.Forms.Panel();
            this.pnA1 = new System.Windows.Forms.Panel();
            this.pnB4 = new System.Windows.Forms.Panel();
            this.pnB3 = new System.Windows.Forms.Panel();
            this.pnB2 = new System.Windows.Forms.Panel();
            this.pnB1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnResetControls = new System.Windows.Forms.Button();
            this.btnToggleRandomControls = new System.Windows.Forms.Button();
            this.btnToggleAllControls = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnApplyCustomSpeed = new System.Windows.Forms.Button();
            this.tbCustomSpeed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDefaultSpeed = new System.Windows.Forms.Button();
            this.tbCurrentSpeed = new System.Windows.Forms.TextBox();
            this.btnResetSpeed = new System.Windows.Forms.Button();
            this.btnRandomSpeed = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trbSpeed = new System.Windows.Forms.TrackBar();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.tbLogInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tspConnection = new System.Windows.Forms.ToolStripProgressBar();
            this.tslConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbbComPorts = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.trbTilt)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSpeed)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tilt";
            // 
            // tbCurrentTilt
            // 
            this.tbCurrentTilt.Enabled = false;
            this.tbCurrentTilt.Location = new System.Drawing.Point(6, 20);
            this.tbCurrentTilt.Name = "tbCurrentTilt";
            this.tbCurrentTilt.Size = new System.Drawing.Size(122, 22);
            this.tbCurrentTilt.TabIndex = 0;
            // 
            // btnResetTilt
            // 
            this.btnResetTilt.Location = new System.Drawing.Point(65, 114);
            this.btnResetTilt.Name = "btnResetTilt";
            this.btnResetTilt.Size = new System.Drawing.Size(96, 23);
            this.btnResetTilt.TabIndex = 5;
            this.btnResetTilt.Text = "Reset";
            this.btnResetTilt.UseVisualStyleBackColor = true;
            // 
            // btnRandomTilt
            // 
            this.btnRandomTilt.Location = new System.Drawing.Point(65, 85);
            this.btnRandomTilt.Name = "btnRandomTilt";
            this.btnRandomTilt.Size = new System.Drawing.Size(96, 23);
            this.btnRandomTilt.TabIndex = 2;
            this.btnRandomTilt.Text = "Random";
            this.btnRandomTilt.UseVisualStyleBackColor = true;
            // 
            // btnDefaultTilt
            // 
            this.btnDefaultTilt.Location = new System.Drawing.Point(65, 55);
            this.btnDefaultTilt.Name = "btnDefaultTilt";
            this.btnDefaultTilt.Size = new System.Drawing.Size(96, 24);
            this.btnDefaultTilt.TabIndex = 1;
            this.btnDefaultTilt.Text = "Default (..)";
            this.btnDefaultTilt.UseVisualStyleBackColor = true;
            // 
            // trbTilt
            // 
            this.trbTilt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trbTilt.Location = new System.Drawing.Point(6, 54);
            this.trbTilt.Maximum = 30;
            this.trbTilt.Name = "trbTilt";
            this.trbTilt.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trbTilt.Size = new System.Drawing.Size(56, 169);
            this.trbTilt.TabIndex = 7;
            this.trbTilt.TickFrequency = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnApplyCustomTilt);
            this.groupBox1.Controls.Add(this.tbCustomTilt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDefaultTilt);
            this.groupBox1.Controls.Add(this.tbCurrentTilt);
            this.groupBox1.Controls.Add(this.btnResetTilt);
            this.groupBox1.Controls.Add(this.btnRandomTilt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.trbTilt);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 232);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Field Tilt";
            // 
            // btnApplyCustomTilt
            // 
            this.btnApplyCustomTilt.Location = new System.Drawing.Point(65, 171);
            this.btnApplyCustomTilt.Name = "btnApplyCustomTilt";
            this.btnApplyCustomTilt.Size = new System.Drawing.Size(96, 51);
            this.btnApplyCustomTilt.TabIndex = 9;
            this.btnApplyCustomTilt.Text = "Apply";
            this.btnApplyCustomTilt.UseVisualStyleBackColor = true;
            // 
            // tbCustomTilt
            // 
            this.tbCustomTilt.Location = new System.Drawing.Point(65, 143);
            this.tbCustomTilt.Name = "tbCustomTilt";
            this.tbCustomTilt.Size = new System.Drawing.Size(96, 22);
            this.tbCustomTilt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(35, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "30";
            // 
            // cbA1
            // 
            this.cbA1.AutoSize = true;
            this.cbA1.Location = new System.Drawing.Point(6, 29);
            this.cbA1.Name = "cbA1";
            this.cbA1.Size = new System.Drawing.Size(18, 17);
            this.cbA1.TabIndex = 11;
            this.cbA1.UseVisualStyleBackColor = true;
            // 
            // cbB1
            // 
            this.cbB1.AutoSize = true;
            this.cbB1.Location = new System.Drawing.Point(47, 29);
            this.cbB1.Name = "cbB1";
            this.cbB1.Size = new System.Drawing.Size(18, 17);
            this.cbB1.TabIndex = 12;
            this.cbB1.UseVisualStyleBackColor = true;
            // 
            // cbA2
            // 
            this.cbA2.AutoSize = true;
            this.cbA2.Location = new System.Drawing.Point(6, 58);
            this.cbA2.Name = "cbA2";
            this.cbA2.Size = new System.Drawing.Size(18, 17);
            this.cbA2.TabIndex = 13;
            this.cbA2.UseVisualStyleBackColor = true;
            // 
            // cbA3
            // 
            this.cbA3.AutoSize = true;
            this.cbA3.Location = new System.Drawing.Point(6, 89);
            this.cbA3.Name = "cbA3";
            this.cbA3.Size = new System.Drawing.Size(18, 17);
            this.cbA3.TabIndex = 14;
            this.cbA3.UseVisualStyleBackColor = true;
            // 
            // cbB4
            // 
            this.cbB4.AutoSize = true;
            this.cbB4.Location = new System.Drawing.Point(47, 122);
            this.cbB4.Name = "cbB4";
            this.cbB4.Size = new System.Drawing.Size(18, 17);
            this.cbB4.TabIndex = 18;
            this.cbB4.UseVisualStyleBackColor = true;
            // 
            // cbB3
            // 
            this.cbB3.AutoSize = true;
            this.cbB3.Location = new System.Drawing.Point(47, 89);
            this.cbB3.Name = "cbB3";
            this.cbB3.Size = new System.Drawing.Size(18, 17);
            this.cbB3.TabIndex = 17;
            this.cbB3.UseVisualStyleBackColor = true;
            // 
            // cbB2
            // 
            this.cbB2.AutoSize = true;
            this.cbB2.Location = new System.Drawing.Point(47, 58);
            this.cbB2.Name = "cbB2";
            this.cbB2.Size = new System.Drawing.Size(18, 17);
            this.cbB2.TabIndex = 16;
            this.cbB2.UseVisualStyleBackColor = true;
            // 
            // cbA4
            // 
            this.cbA4.AutoSize = true;
            this.cbA4.Location = new System.Drawing.Point(6, 122);
            this.cbA4.Name = "cbA4";
            this.cbA4.Size = new System.Drawing.Size(18, 17);
            this.cbA4.TabIndex = 15;
            this.cbA4.UseVisualStyleBackColor = true;
            // 
            // pnA4
            // 
            this.pnA4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnA4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnA4.Location = new System.Drawing.Point(30, 114);
            this.pnA4.Name = "pnA4";
            this.pnA4.Size = new System.Drawing.Size(25, 25);
            this.pnA4.TabIndex = 24;
            // 
            // pnA3
            // 
            this.pnA3.BackColor = System.Drawing.Color.LimeGreen;
            this.pnA3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnA3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnA3.Location = new System.Drawing.Point(41, 83);
            this.pnA3.Name = "pnA3";
            this.pnA3.Size = new System.Drawing.Size(25, 25);
            this.pnA3.TabIndex = 23;
            // 
            // pnA2
            // 
            this.pnA2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnA2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnA2.Location = new System.Drawing.Point(41, 52);
            this.pnA2.Name = "pnA2";
            this.pnA2.Size = new System.Drawing.Size(25, 25);
            this.pnA2.TabIndex = 22;
            // 
            // pnA1
            // 
            this.pnA1.BackColor = System.Drawing.Color.Red;
            this.pnA1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnA1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnA1.Location = new System.Drawing.Point(30, 21);
            this.pnA1.Name = "pnA1";
            this.pnA1.Size = new System.Drawing.Size(25, 25);
            this.pnA1.TabIndex = 21;
            // 
            // pnB4
            // 
            this.pnB4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnB4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnB4.Location = new System.Drawing.Point(16, 114);
            this.pnB4.Name = "pnB4";
            this.pnB4.Size = new System.Drawing.Size(25, 25);
            this.pnB4.TabIndex = 29;
            // 
            // pnB3
            // 
            this.pnB3.BackColor = System.Drawing.Color.LimeGreen;
            this.pnB3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnB3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnB3.Location = new System.Drawing.Point(6, 83);
            this.pnB3.Name = "pnB3";
            this.pnB3.Size = new System.Drawing.Size(25, 25);
            this.pnB3.TabIndex = 28;
            // 
            // pnB2
            // 
            this.pnB2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnB2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnB2.Location = new System.Drawing.Point(6, 52);
            this.pnB2.Name = "pnB2";
            this.pnB2.Size = new System.Drawing.Size(25, 25);
            this.pnB2.TabIndex = 27;
            // 
            // pnB1
            // 
            this.pnB1.BackColor = System.Drawing.Color.Red;
            this.pnB1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnB1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnB1.Location = new System.Drawing.Point(16, 21);
            this.pnB1.Name = "pnB1";
            this.pnB1.Size = new System.Drawing.Size(25, 25);
            this.pnB1.TabIndex = 26;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pnA1);
            this.groupBox3.Controls.Add(this.pnA2);
            this.groupBox3.Controls.Add(this.pnA3);
            this.groupBox3.Controls.Add(this.pnA4);
            this.groupBox3.Controls.Add(this.cbA4);
            this.groupBox3.Controls.Add(this.cbA1);
            this.groupBox3.Controls.Add(this.cbA3);
            this.groupBox3.Controls.Add(this.cbA2);
            this.groupBox3.Location = new System.Drawing.Point(6, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(75, 145);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Side A";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pnB2);
            this.groupBox5.Controls.Add(this.cbB4);
            this.groupBox5.Controls.Add(this.pnB4);
            this.groupBox5.Controls.Add(this.cbB3);
            this.groupBox5.Controls.Add(this.pnB1);
            this.groupBox5.Controls.Add(this.cbB2);
            this.groupBox5.Controls.Add(this.pnB3);
            this.groupBox5.Controls.Add(this.cbB1);
            this.groupBox5.Location = new System.Drawing.Point(87, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(75, 145);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Side B";
            // 
            // btnResetControls
            // 
            this.btnResetControls.Location = new System.Drawing.Point(87, 197);
            this.btnResetControls.Name = "btnResetControls";
            this.btnResetControls.Size = new System.Drawing.Size(75, 25);
            this.btnResetControls.TabIndex = 33;
            this.btnResetControls.Text = "Reset";
            this.btnResetControls.UseVisualStyleBackColor = true;
            // 
            // btnToggleRandomControls
            // 
            this.btnToggleRandomControls.Location = new System.Drawing.Point(6, 197);
            this.btnToggleRandomControls.Name = "btnToggleRandomControls";
            this.btnToggleRandomControls.Size = new System.Drawing.Size(75, 25);
            this.btnToggleRandomControls.TabIndex = 34;
            this.btnToggleRandomControls.Text = "Random";
            this.btnToggleRandomControls.UseVisualStyleBackColor = true;
            // 
            // btnToggleAllControls
            // 
            this.btnToggleAllControls.Location = new System.Drawing.Point(6, 172);
            this.btnToggleAllControls.Name = "btnToggleAllControls";
            this.btnToggleAllControls.Size = new System.Drawing.Size(156, 23);
            this.btnToggleAllControls.TabIndex = 35;
            this.btnToggleAllControls.Text = "Toggle All";
            this.btnToggleAllControls.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnToggleAllControls);
            this.groupBox6.Controls.Add(this.groupBox3);
            this.groupBox6.Controls.Add(this.btnToggleRandomControls);
            this.groupBox6.Controls.Add(this.groupBox5);
            this.groupBox6.Controls.Add(this.btnResetControls);
            this.groupBox6.Location = new System.Drawing.Point(364, 49);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(172, 232);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Control Sensors";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnApplyCustomSpeed);
            this.groupBox4.Controls.Add(this.tbCustomSpeed);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnDefaultSpeed);
            this.groupBox4.Controls.Add(this.tbCurrentSpeed);
            this.groupBox4.Controls.Add(this.btnResetSpeed);
            this.groupBox4.Controls.Add(this.btnRandomSpeed);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.trbSpeed);
            this.groupBox4.Location = new System.Drawing.Point(188, 49);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(170, 232);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bouncer Speed";
            // 
            // btnApplyCustomSpeed
            // 
            this.btnApplyCustomSpeed.Location = new System.Drawing.Point(65, 171);
            this.btnApplyCustomSpeed.Name = "btnApplyCustomSpeed";
            this.btnApplyCustomSpeed.Size = new System.Drawing.Size(96, 51);
            this.btnApplyCustomSpeed.TabIndex = 9;
            this.btnApplyCustomSpeed.Text = "Apply";
            this.btnApplyCustomSpeed.UseVisualStyleBackColor = true;
            // 
            // tbCustomSpeed
            // 
            this.tbCustomSpeed.Location = new System.Drawing.Point(65, 143);
            this.tbCustomSpeed.Name = "tbCustomSpeed";
            this.tbCustomSpeed.Size = new System.Drawing.Size(96, 22);
            this.tbCustomSpeed.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Speed";
            // 
            // btnDefaultSpeed
            // 
            this.btnDefaultSpeed.Location = new System.Drawing.Point(65, 55);
            this.btnDefaultSpeed.Name = "btnDefaultSpeed";
            this.btnDefaultSpeed.Size = new System.Drawing.Size(96, 24);
            this.btnDefaultSpeed.TabIndex = 1;
            this.btnDefaultSpeed.Text = "Default (..)";
            this.btnDefaultSpeed.UseVisualStyleBackColor = true;
            // 
            // tbCurrentSpeed
            // 
            this.tbCurrentSpeed.Enabled = false;
            this.tbCurrentSpeed.Location = new System.Drawing.Point(6, 20);
            this.tbCurrentSpeed.Name = "tbCurrentSpeed";
            this.tbCurrentSpeed.Size = new System.Drawing.Size(103, 22);
            this.tbCurrentSpeed.TabIndex = 0;
            // 
            // btnResetSpeed
            // 
            this.btnResetSpeed.Location = new System.Drawing.Point(65, 114);
            this.btnResetSpeed.Name = "btnResetSpeed";
            this.btnResetSpeed.Size = new System.Drawing.Size(96, 23);
            this.btnResetSpeed.TabIndex = 5;
            this.btnResetSpeed.Text = "Reset";
            this.btnResetSpeed.UseVisualStyleBackColor = true;
            // 
            // btnRandomSpeed
            // 
            this.btnRandomSpeed.Location = new System.Drawing.Point(65, 85);
            this.btnRandomSpeed.Name = "btnRandomSpeed";
            this.btnRandomSpeed.Size = new System.Drawing.Size(96, 23);
            this.btnRandomSpeed.TabIndex = 2;
            this.btnRandomSpeed.Text = "Random";
            this.btnRandomSpeed.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(35, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(27, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "100";
            // 
            // trbSpeed
            // 
            this.trbSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trbSpeed.Location = new System.Drawing.Point(6, 54);
            this.trbSpeed.Maximum = 30;
            this.trbSpeed.Name = "trbSpeed";
            this.trbSpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trbSpeed.Size = new System.Drawing.Size(56, 169);
            this.trbSpeed.TabIndex = 7;
            this.trbSpeed.TickFrequency = 3;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearLog.Location = new System.Drawing.Point(438, 476);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(98, 23);
            this.btnClearLog.TabIndex = 14;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            // 
            // tbLogInput
            // 
            this.tbLogInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLogInput.Location = new System.Drawing.Point(12, 477);
            this.tbLogInput.Name = "tbLogInput";
            this.tbLogInput.Size = new System.Drawing.Size(339, 22);
            this.tbLogInput.TabIndex = 14;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(357, 476);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Log";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(44, 292);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(500, 1);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // lbLog
            // 
            this.lbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 16;
            this.lbLog.Items.AddRange(new object[] {
            "t",
            "t",
            "t",
            "t",
            "t",
            "t",
            "t",
            "t",
            "t",
            "t"});
            this.lbLog.Location = new System.Drawing.Point(12, 304);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(524, 164);
            this.lbLog.TabIndex = 17;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(-3, 292);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(20, 1);
            this.flowLayoutPanel2.TabIndex = 17;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspConnection,
            this.tslConnection});
            this.statusStrip.Location = new System.Drawing.Point(0, 516);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip.Size = new System.Drawing.Size(544, 28);
            this.statusStrip.TabIndex = 18;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tspConnection
            // 
            this.tspConnection.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tspConnection.Name = "tspConnection";
            this.tspConnection.Size = new System.Drawing.Size(100, 22);
            // 
            // tslConnection
            // 
            this.tslConnection.Name = "tslConnection";
            this.tslConnection.Size = new System.Drawing.Size(80, 23);
            this.tslConnection.Text = "Connected";
            // 
            // cbbComPorts
            // 
            this.cbbComPorts.FormattingEnabled = true;
            this.cbbComPorts.Location = new System.Drawing.Point(12, 12);
            this.cbbComPorts.Name = "cbbComPorts";
            this.cbbComPorts.Size = new System.Drawing.Size(113, 24);
            this.cbbComPorts.TabIndex = 19;
            this.cbbComPorts.Text = "Select port";
            this.cbbComPorts.SelectedIndexChanged += new System.EventHandler(this.cbbComPorts_SelectedIndexChanged);
            this.cbbComPorts.Click += new System.EventHandler(this.cbbComPorts_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(131, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(81, 24);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 42);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(550, 1);
            this.flowLayoutPanel3.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 544);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cbbComPorts);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbLogInput);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(562, 536);
            this.Name = "Form1";
            this.Text = "Bouncer Controller";
            ((System.ComponentModel.ISupportInitialize)(this.trbTilt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSpeed)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCurrentTilt;
        private System.Windows.Forms.Button btnResetTilt;
        private System.Windows.Forms.Button btnRandomTilt;
        private System.Windows.Forms.Button btnDefaultTilt;
        private System.Windows.Forms.TrackBar trbTilt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnApplyCustomTilt;
        private System.Windows.Forms.TextBox tbCustomTilt;
        private System.Windows.Forms.CheckBox cbA1;
        private System.Windows.Forms.CheckBox cbB1;
        private System.Windows.Forms.CheckBox cbA2;
        private System.Windows.Forms.CheckBox cbA3;
        private System.Windows.Forms.CheckBox cbB4;
        private System.Windows.Forms.CheckBox cbB3;
        private System.Windows.Forms.CheckBox cbB2;
        private System.Windows.Forms.CheckBox cbA4;
        private System.Windows.Forms.Panel pnA4;
        private System.Windows.Forms.Panel pnA3;
        private System.Windows.Forms.Panel pnA2;
        private System.Windows.Forms.Panel pnA1;
        private System.Windows.Forms.Panel pnB4;
        private System.Windows.Forms.Panel pnB3;
        private System.Windows.Forms.Panel pnB2;
        private System.Windows.Forms.Panel pnB1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnResetControls;
        private System.Windows.Forms.Button btnToggleRandomControls;
        private System.Windows.Forms.Button btnToggleAllControls;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnApplyCustomSpeed;
        private System.Windows.Forms.TextBox tbCustomSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDefaultSpeed;
        private System.Windows.Forms.TextBox tbCurrentSpeed;
        private System.Windows.Forms.Button btnResetSpeed;
        private System.Windows.Forms.Button btnRandomSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trbSpeed;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.TextBox tbLogInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tslConnection;
        private System.Windows.Forms.ToolStripProgressBar tspConnection;
        private System.Windows.Forms.ComboBox cbbComPorts;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}

