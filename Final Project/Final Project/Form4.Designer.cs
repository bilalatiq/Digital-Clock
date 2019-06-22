namespace Final_Project
{
    partial class Countdown
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
            this.lblsec = new System.Windows.Forms.Label();
            this.lblmin = new System.Windows.Forms.Label();
            this.lblhour = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnreset = new System.Windows.Forms.Button();
            this.numhour = new System.Windows.Forms.NumericUpDown();
            this.nummin = new System.Windows.Forms.NumericUpDown();
            this.numsec = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numhour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nummin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numsec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblsec
            // 
            this.lblsec.AutoSize = true;
            this.lblsec.Font = new System.Drawing.Font("Eras Bold ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblsec.Location = new System.Drawing.Point(522, 196);
            this.lblsec.Name = "lblsec";
            this.lblsec.Size = new System.Drawing.Size(57, 36);
            this.lblsec.TabIndex = 19;
            this.lblsec.Text = "00";
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.Font = new System.Drawing.Font("Eras Bold ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmin.Location = new System.Drawing.Point(424, 196);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(57, 36);
            this.lblmin.TabIndex = 18;
            this.lblmin.Text = "00";
            // 
            // lblhour
            // 
            this.lblhour.AutoSize = true;
            this.lblhour.Font = new System.Drawing.Font("Eras Bold ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblhour.Location = new System.Drawing.Point(327, 196);
            this.lblhour.Name = "lblhour";
            this.lblhour.Size = new System.Drawing.Size(57, 36);
            this.lblhour.TabIndex = 17;
            this.lblhour.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(500, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(400, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Minutes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(312, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Hours";
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnstart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnstart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnstart.Location = new System.Drawing.Point(407, 262);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(90, 49);
            this.btnstart.TabIndex = 22;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnreset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnreset.Location = new System.Drawing.Point(407, 317);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(90, 49);
            this.btnreset.TabIndex = 23;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Visible = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // numhour
            // 
            this.numhour.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.numhour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numhour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numhour.Location = new System.Drawing.Point(318, 115);
            this.numhour.Name = "numhour";
            this.numhour.Size = new System.Drawing.Size(68, 29);
            this.numhour.TabIndex = 25;
            this.numhour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nummin
            // 
            this.nummin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nummin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nummin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nummin.Location = new System.Drawing.Point(417, 115);
            this.nummin.Name = "nummin";
            this.nummin.Size = new System.Drawing.Size(68, 29);
            this.nummin.TabIndex = 26;
            this.nummin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numsec
            // 
            this.numsec.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.numsec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numsec.Location = new System.Drawing.Point(514, 115);
            this.numsec.Name = "numsec";
            this.numsec.Size = new System.Drawing.Size(68, 29);
            this.numsec.TabIndex = 27;
            this.numsec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox1.Image = global::Final_Project.Properties.Resources._080966_glossy_silver_icon_business_clock1;
            this.pictureBox1.Location = new System.Drawing.Point(238, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Desktop;
            this.label4.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(287, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 32);
            this.label4.TabIndex = 72;
            this.label4.Text = "Countdown";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final_Project.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(653, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 74;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Countdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = global::Final_Project.Properties.Resources.shining_lines_of_light_backgrounds_wallpapers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 462);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numsec);
            this.Controls.Add(this.nummin);
            this.Controls.Add(this.numhour);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.lblsec);
            this.Controls.Add(this.lblmin);
            this.Controls.Add(this.lblhour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Countdown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Countdown";
            ((System.ComponentModel.ISupportInitialize)(this.numhour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nummin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numsec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsec;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label lblhour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.NumericUpDown numhour;
        private System.Windows.Forms.NumericUpDown nummin;
        private System.Windows.Forms.NumericUpDown numsec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}