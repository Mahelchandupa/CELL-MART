namespace projectPractice1
{
    partial class MenuSetting
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbCansel = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbHomeBack = new System.Windows.Forms.PictureBox();
            this.btnReloadHistory = new System.Windows.Forms.Button();
            this.btnSimActHistory = new System.Windows.Forms.Button();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCansel)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomeBack)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pbBack);
            this.panel1.Controls.Add(this.pbCansel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-29, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 93);
            this.panel1.TabIndex = 0;
            // 
            // pbBack
            // 
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Image = global::projectPractice1.Properties.Resources.icons8_back_to_48;
            this.pbBack.Location = new System.Drawing.Point(508, 13);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(34, 29);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 4;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // pbCansel
            // 
            this.pbCansel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCansel.Image = global::projectPractice1.Properties.Resources.icons8_cancel_48__1_;
            this.pbCansel.Location = new System.Drawing.Point(548, 13);
            this.pbCansel.Name = "pbCansel";
            this.pbCansel.Size = new System.Drawing.Size(32, 29);
            this.pbCansel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCansel.TabIndex = 3;
            this.pbCansel.TabStop = false;
            this.pbCansel.Click += new System.EventHandler(this.pbCansel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(272, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "History";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-7, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 40);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Controls.Add(this.pbHomeBack);
            this.panel3.Location = new System.Drawing.Point(-7, 505);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(574, 76);
            this.panel3.TabIndex = 6;
            // 
            // pbHomeBack
            // 
            this.pbHomeBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHomeBack.Image = global::projectPractice1.Properties.Resources.icons8_home_page_64;
            this.pbHomeBack.Location = new System.Drawing.Point(268, 17);
            this.pbHomeBack.Name = "pbHomeBack";
            this.pbHomeBack.Size = new System.Drawing.Size(48, 48);
            this.pbHomeBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHomeBack.TabIndex = 7;
            this.pbHomeBack.TabStop = false;
            this.pbHomeBack.Click += new System.EventHandler(this.pbHomeBack_Click);
            // 
            // btnReloadHistory
            // 
            this.btnReloadHistory.BackgroundImage = global::projectPractice1.Properties.Resources._360_F_410641572_pG4NX6I9DZfiGszulXLnUg7TeR2wj7VO;
            this.btnReloadHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReloadHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReloadHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadHistory.ForeColor = System.Drawing.Color.White;
            this.btnReloadHistory.Location = new System.Drawing.Point(92, 207);
            this.btnReloadHistory.Name = "btnReloadHistory";
            this.btnReloadHistory.Size = new System.Drawing.Size(376, 52);
            this.btnReloadHistory.TabIndex = 5;
            this.btnReloadHistory.Text = "Reload History";
            this.btnReloadHistory.UseVisualStyleBackColor = true;
            this.btnReloadHistory.Click += new System.EventHandler(this.btnReloadHistory_Click);
            // 
            // btnSimActHistory
            // 
            this.btnSimActHistory.BackgroundImage = global::projectPractice1.Properties.Resources._360_F_410641572_pG4NX6I9DZfiGszulXLnUg7TeR2wj7VO;
            this.btnSimActHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSimActHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimActHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimActHistory.ForeColor = System.Drawing.Color.White;
            this.btnSimActHistory.Location = new System.Drawing.Point(92, 319);
            this.btnSimActHistory.Name = "btnSimActHistory";
            this.btnSimActHistory.Size = new System.Drawing.Size(376, 50);
            this.btnSimActHistory.TabIndex = 4;
            this.btnSimActHistory.Text = "SIM Activation \r\nHistory";
            this.btnSimActHistory.UseVisualStyleBackColor = true;
            this.btnSimActHistory.Click += new System.EventHandler(this.btnSimActHistory_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this.btnReloadHistory;
            // 
            // MenuSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(567, 582);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnReloadHistory);
            this.Controls.Add(this.btnSimActHistory);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuSetting";
            this.Load += new System.EventHandler(this.MenuSetting_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCansel)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHomeBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Button btnSimActHistory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbCansel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReloadHistory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbHomeBack;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}