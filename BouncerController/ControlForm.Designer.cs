namespace BouncerController {
    partial class ControlForm {
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
            this.btnALeft = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRightA = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRightB = new System.Windows.Forms.Button();
            this.btnLeftB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnALeft
            // 
            this.btnALeft.Location = new System.Drawing.Point(6, 21);
            this.btnALeft.Name = "btnALeft";
            this.btnALeft.Size = new System.Drawing.Size(75, 40);
            this.btnALeft.TabIndex = 0;
            this.btnALeft.Text = "Left";
            this.btnALeft.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRightA);
            this.groupBox1.Controls.Add(this.btnALeft);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 70);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bouncer A";
            // 
            // btnRightA
            // 
            this.btnRightA.Location = new System.Drawing.Point(87, 21);
            this.btnRightA.Name = "btnRightA";
            this.btnRightA.Size = new System.Drawing.Size(75, 40);
            this.btnRightA.TabIndex = 1;
            this.btnRightA.Text = "Right";
            this.btnRightA.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRightB);
            this.groupBox2.Controls.Add(this.btnLeftB);
            this.groupBox2.Location = new System.Drawing.Point(12, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 70);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bouncer B";
            // 
            // btnRightB
            // 
            this.btnRightB.Location = new System.Drawing.Point(87, 21);
            this.btnRightB.Name = "btnRightB";
            this.btnRightB.Size = new System.Drawing.Size(75, 40);
            this.btnRightB.TabIndex = 1;
            this.btnRightB.Text = "Right";
            this.btnRightB.UseVisualStyleBackColor = true;
            // 
            // btnLeftB
            // 
            this.btnLeftB.Location = new System.Drawing.Point(6, 21);
            this.btnLeftB.Name = "btnLeftB";
            this.btnLeftB.Size = new System.Drawing.Size(75, 40);
            this.btnLeftB.TabIndex = 0;
            this.btnLeftB.Text = "Left";
            this.btnLeftB.UseVisualStyleBackColor = true;
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 210);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ControlForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Control";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnALeft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRightA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRightB;
        private System.Windows.Forms.Button btnLeftB;
    }
}