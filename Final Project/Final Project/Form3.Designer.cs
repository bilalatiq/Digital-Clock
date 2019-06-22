namespace Final_Project
{
    partial class stopwatch
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblms = new System.Windows.Forms.Label();
            this.lblsec = new System.Windows.Forms.Label();
            this.lblmin = new System.Windows.Forms.Label();
            this.lblhour = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnlap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Centaur", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(443, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 41);
            this.label3.TabIndex = 19;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Centaur", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(341, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 41);
            this.label2.TabIndex = 18;
            this.label2.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Centaur", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(238, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 41);
            this.label1.TabIndex = 17;
            this.label1.Text = ":";
            // 
            // lblms
            // 
            this.lblms.AutoSize = true;
            this.lblms.Font = new System.Drawing.Font("Centaur", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblms.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblms.Location = new System.Drawing.Point(468, 109);
            this.lblms.Name = "lblms";
            this.lblms.Size = new System.Drawing.Size(73, 53);
            this.lblms.TabIndex = 16;
            this.lblms.Text = "00";
            // 
            // lblsec
            // 
            this.lblsec.AutoSize = true;
            this.lblsec.Font = new System.Drawing.Font("Centaur", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblsec.Location = new System.Drawing.Point(366, 110);
            this.lblsec.Name = "lblsec";
            this.lblsec.Size = new System.Drawing.Size(73, 53);
            this.lblsec.TabIndex = 15;
            this.lblsec.Text = "00";
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.Font = new System.Drawing.Font("Centaur", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmin.Location = new System.Drawing.Point(264, 110);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(73, 53);
            this.lblmin.TabIndex = 14;
            this.lblmin.Text = "00";
            // 
            // lblhour
            // 
            this.lblhour.AutoSize = true;
            this.lblhour.Font = new System.Drawing.Font("Centaur", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblhour.Location = new System.Drawing.Point(164, 110);
            this.lblhour.Name = "lblhour";
            this.lblhour.Size = new System.Drawing.Size(73, 53);
            this.lblhour.TabIndex = 13;
            this.lblhour.Text = "00";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Centaur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(10, 166);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 192);
            this.listBox1.TabIndex = 20;
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnstart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnstart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnstart.Location = new System.Drawing.Point(306, 187);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(95, 50);
            this.btnstart.TabIndex = 21;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.btn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnlap
            // 
            this.btnlap.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnlap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlap.Location = new System.Drawing.Point(306, 243);
            this.btnlap.Name = "btnlap";
            this.btnlap.Size = new System.Drawing.Size(95, 50);
            this.btnlap.TabIndex = 22;
            this.btnlap.Text = "Lap";
            this.btnlap.UseVisualStyleBackColor = false;
            this.btnlap.Visible = false;
            this.btnlap.Click += new System.EventHandler(this.btnlap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox1.Image = global::Final_Project.Properties.Resources._080966_glossy_silver_icon_business_clock1;
            this.pictureBox1.Location = new System.Drawing.Point(206, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Desktop;
            this.label4.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(255, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 32);
            this.label4.TabIndex = 70;
            this.label4.Text = "Stopwatch";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final_Project.Properties.Resources.Icon_home_white;
            this.pictureBox2.Location = new System.Drawing.Point(1, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // stopwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = global::Final_Project.Properties.Resources.black_city_backgrounds_powerpoint;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 444);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnlap);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblms);
            this.Controls.Add(this.lblsec);
            this.Controls.Add(this.lblmin);
            this.Controls.Add(this.lblhour);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "stopwatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stopwatch";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblms;
        private System.Windows.Forms.Label lblsec;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label lblhour;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnlap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}