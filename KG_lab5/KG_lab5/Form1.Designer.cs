namespace KG_lab5
{
    partial class Form1
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.inputTb = new System.Windows.Forms.TextBox();
            this.lbBtn = new System.Windows.Forms.Button();
            this.cbBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox.Location = new System.Drawing.Point(300, 10);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(750, 601);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // inputTb
            // 
            this.inputTb.Location = new System.Drawing.Point(2, 12);
            this.inputTb.Multiline = true;
            this.inputTb.Name = "inputTb";
            this.inputTb.Size = new System.Drawing.Size(294, 294);
            this.inputTb.TabIndex = 1;
            this.inputTb.TextChanged += new System.EventHandler(this.inputTb_TextChanged);
            // 
            // lbBtn
            // 
            this.lbBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbBtn.Location = new System.Drawing.Point(12, 333);
            this.lbBtn.Name = "lbBtn";
            this.lbBtn.Size = new System.Drawing.Size(128, 53);
            this.lbBtn.TabIndex = 2;
            this.lbBtn.Text = "Liang–Barsky";
            this.lbBtn.UseVisualStyleBackColor = true;
            this.lbBtn.Click += new System.EventHandler(this.lbBtn_Click);
            // 
            // cbBtn
            // 
            this.cbBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbBtn.Location = new System.Drawing.Point(159, 333);
            this.cbBtn.Name = "cbBtn";
            this.cbBtn.Size = new System.Drawing.Size(128, 53);
            this.cbBtn.TabIndex = 3;
            this.cbBtn.Text = "Clip line using a polygon";
            this.cbBtn.UseVisualStyleBackColor = true;
            this.cbBtn.Click += new System.EventHandler(this.cbBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1192, 609);
            this.Controls.Add(this.cbBtn);
            this.Controls.Add(this.lbBtn);
            this.Controls.Add(this.inputTb);
            this.Controls.Add(this.pictureBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Lab5";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox inputTb;
        private System.Windows.Forms.Button lbBtn;
        private System.Windows.Forms.Button cbBtn;
    }
}

