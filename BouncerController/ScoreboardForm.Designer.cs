namespace BouncerController {
    partial class ScoreboardForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreboardForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lbScoreA = new System.Windows.Forms.Label();
            this.lbScoreB = new System.Windows.Forms.Label();
            this.lbScoreALabel = new System.Windows.Forms.Label();
            this.lbScoreBLabel = new System.Windows.Forms.Label();
            this.scorePanel = new System.Windows.Forms.Panel();
            this.lbDivider = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tmUpdate = new System.Windows.Forms.Timer(this.components);
            this.scorePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnClose.Location = new System.Drawing.Point(46, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMinimize.Location = new System.Drawing.Point(11, 11);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 32);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "□";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lbScoreA
            // 
            this.lbScoreA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbScoreA.AutoSize = true;
            this.lbScoreA.Font = new System.Drawing.Font("Baloo Bhaina", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScoreA.Location = new System.Drawing.Point(72, 120);
            this.lbScoreA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbScoreA.Name = "lbScoreA";
            this.lbScoreA.Size = new System.Drawing.Size(140, 193);
            this.lbScoreA.TabIndex = 3;
            this.lbScoreA.Text = "4";
            // 
            // lbScoreB
            // 
            this.lbScoreB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbScoreB.AutoSize = true;
            this.lbScoreB.Font = new System.Drawing.Font("Baloo Bhaina", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScoreB.Location = new System.Drawing.Point(341, 120);
            this.lbScoreB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbScoreB.Name = "lbScoreB";
            this.lbScoreB.Size = new System.Drawing.Size(120, 193);
            this.lbScoreB.TabIndex = 4;
            this.lbScoreB.Text = "1";
            // 
            // lbScoreALabel
            // 
            this.lbScoreALabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbScoreALabel.AutoSize = true;
            this.lbScoreALabel.Font = new System.Drawing.Font("Baloo Bhaina", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScoreALabel.Location = new System.Drawing.Point(12, 0);
            this.lbScoreALabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbScoreALabel.Name = "lbScoreALabel";
            this.lbScoreALabel.Size = new System.Drawing.Size(271, 129);
            this.lbScoreALabel.TabIndex = 5;
            this.lbScoreALabel.Text = "TEAM A";
            // 
            // lbScoreBLabel
            // 
            this.lbScoreBLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbScoreBLabel.AutoSize = true;
            this.lbScoreBLabel.Font = new System.Drawing.Font("Baloo Bhaina", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScoreBLabel.Location = new System.Drawing.Point(265, 11);
            this.lbScoreBLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbScoreBLabel.Name = "lbScoreBLabel";
            this.lbScoreBLabel.Size = new System.Drawing.Size(271, 129);
            this.lbScoreBLabel.TabIndex = 6;
            this.lbScoreBLabel.Text = "TEAM B";
            // 
            // scorePanel
            // 
            this.scorePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scorePanel.BackColor = System.Drawing.Color.Transparent;
            this.scorePanel.Controls.Add(this.lbDivider);
            this.scorePanel.Controls.Add(this.pictureBox1);
            this.scorePanel.Controls.Add(this.lbScoreALabel);
            this.scorePanel.Controls.Add(this.lbScoreB);
            this.scorePanel.Controls.Add(this.lbScoreBLabel);
            this.scorePanel.Controls.Add(this.lbScoreA);
            this.scorePanel.Controls.Add(this.lbTime);
            this.scorePanel.Location = new System.Drawing.Point(12, 48);
            this.scorePanel.Name = "scorePanel";
            this.scorePanel.Size = new System.Drawing.Size(548, 392);
            this.scorePanel.TabIndex = 7;
            // 
            // lbDivider
            // 
            this.lbDivider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDivider.AutoSize = true;
            this.lbDivider.Font = new System.Drawing.Font("Baloo Bhaina", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDivider.Location = new System.Drawing.Point(197, 120);
            this.lbDivider.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDivider.Name = "lbDivider";
            this.lbDivider.Size = new System.Drawing.Size(116, 193);
            this.lbDivider.TabIndex = 9;
            this.lbDivider.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbTime
            // 
            this.lbTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Baloo Bhaina", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(125, 22);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(531, 193);
            this.lbTime.TabIndex = 8;
            this.lbTime.Text = "Time: 5:00";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 315);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(349, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baloo Bhaina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(81, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "SCOREBOARD";
            // 
            // tmUpdate
            // 
            this.tmUpdate.Enabled = true;
            this.tmUpdate.Interval = 1000;
            this.tmUpdate.Tick += new System.EventHandler(this.tmUpdate_Tick);
            // 
            // ScoreboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(572, 452);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.scorePanel);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ScoreboardForm";
            this.Text = "Scoreboard";
            this.Load += new System.EventHandler(this.ScoreboardForm_Load);
            this.scorePanel.ResumeLayout(false);
            this.scorePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lbScoreA;
        private System.Windows.Forms.Label lbScoreB;
        private System.Windows.Forms.Label lbScoreALabel;
        private System.Windows.Forms.Label lbScoreBLabel;
        private System.Windows.Forms.Panel scorePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmUpdate;
        private System.Windows.Forms.Label lbDivider;
    }
}