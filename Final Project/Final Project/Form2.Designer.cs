namespace Final_Project
{
    partial class digitalclock
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
            this.day = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.time12 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn24 = new System.Windows.Forms.RadioButton();
            this.btn12 = new System.Windows.Forms.RadioButton();
            this.time24 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AmPm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.Font = new System.Drawing.Font("DS-Digital", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.day.Location = new System.Drawing.Point(349, 220);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(121, 36);
            this.day.TabIndex = 5;
            this.day.Text = "Friday";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("DS-Digital", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.date.Location = new System.Drawing.Point(122, 220);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(158, 36);
            this.date.TabIndex = 4;
            this.date.Text = "26 Oct 17";
            // 
            // time12
            // 
            this.time12.AutoSize = true;
            this.time12.Font = new System.Drawing.Font("DS-Digital", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.time12.Location = new System.Drawing.Point(149, 111);
            this.time12.Name = "time12";
            this.time12.Size = new System.Drawing.Size(253, 63);
            this.time12.TabIndex = 3;
            this.time12.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn24
            // 
            this.btn24.AutoSize = true;
            this.btn24.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn24.Location = new System.Drawing.Point(606, 177);
            this.btn24.Name = "btn24";
            this.btn24.Size = new System.Drawing.Size(103, 18);
            this.btn24.TabIndex = 62;
            this.btn24.Text = "                        ";
            this.btn24.UseVisualStyleBackColor = true;
            this.btn24.CheckedChanged += new System.EventHandler(this.btn24_CheckedChanged);
            // 
            // btn12
            // 
            this.btn12.AutoSize = true;
            this.btn12.Checked = true;
            this.btn12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn12.Location = new System.Drawing.Point(606, 137);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(103, 18);
            this.btn12.TabIndex = 63;
            this.btn12.TabStop = true;
            this.btn12.Text = "                        ";
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.CheckedChanged += new System.EventHandler(this.btn12_CheckedChanged);
            // 
            // time24
            // 
            this.time24.AutoSize = true;
            this.time24.Font = new System.Drawing.Font("DS-Digital", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time24.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.time24.Location = new System.Drawing.Point(149, 111);
            this.time24.Name = "time24";
            this.time24.Size = new System.Drawing.Size(253, 63);
            this.time24.TabIndex = 64;
            this.time24.Text = "00:00:00";
            this.time24.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DS-Digital", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(563, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 65;
            this.label1.Text = "24 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DS-Digital", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(568, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 66;
            this.label2.Text = "12 :";
            // 
            // AmPm
            // 
            this.AmPm.AutoSize = true;
            this.AmPm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AmPm.Font = new System.Drawing.Font("DS-Digital", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmPm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AmPm.Location = new System.Drawing.Point(374, 111);
            this.AmPm.Name = "AmPm";
            this.AmPm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AmPm.Size = new System.Drawing.Size(57, 63);
            this.AmPm.TabIndex = 67;
            this.AmPm.Text = "-";
            this.AmPm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(233, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 32);
            this.label3.TabIndex = 68;
            this.label3.Text = "Digital Clock";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox1.Image = global::Final_Project.Properties.Resources._080966_glossy_silver_icon_business_clock1;
            this.pictureBox1.Location = new System.Drawing.Point(184, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final_Project.Properties.Resources.Icon_home_white;
            this.pictureBox2.Location = new System.Drawing.Point(2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // digitalclock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = global::Final_Project.Properties.Resources.black_city_backgrounds_powerpoint;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(668, 356);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AmPm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time24);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn24);
            this.Controls.Add(this.day);
            this.Controls.Add(this.date);
            this.Controls.Add(this.time12);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "digitalclock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.digitalclock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label day;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label time12;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton btn24;
        private System.Windows.Forms.RadioButton btn12;
        private System.Windows.Forms.Label time24;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AmPm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}