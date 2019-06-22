namespace Final_Project
{
    partial class Alarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alarm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn12 = new System.Windows.Forms.RadioButton();
            this.btn24 = new System.Windows.Forms.RadioButton();
            this.nummin = new System.Windows.Forms.NumericUpDown();
            this.numhour = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nummin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numhour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // btn12
            // 
            resources.ApplyResources(this.btn12, "btn12");
            this.btn12.Checked = true;
            this.btn12.Name = "btn12";
            this.btn12.TabStop = true;
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.btn12_Click);
            // 
            // btn24
            // 
            resources.ApplyResources(this.btn24, "btn24");
            this.btn24.Name = "btn24";
            this.btn24.UseVisualStyleBackColor = true;
            this.btn24.Click += new System.EventHandler(this.btn24_Click);
            // 
            // nummin
            // 
            this.nummin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nummin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.nummin, "nummin");
            this.nummin.Name = "nummin";
            // 
            // numhour
            // 
            this.numhour.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.numhour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.numhour, "numhour");
            this.numhour.Name = "numhour";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Name = "label4";
            // 
            // btnset
            // 
            this.btnset.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.btnset, "btnset");
            this.btnset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnset.Name = "btnset";
            this.btnset.UseVisualStyleBackColor = false;
            this.btnset.Click += new System.EventHandler(this.btnset_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1")});
            this.comboBox1.Name = "comboBox1";
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.checkBox2_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Name = "label6";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox1.Image = global::Final_Project.Properties.Resources._080966_glossy_silver_icon_business_clock1;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.SystemColors.Desktop;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Name = "label8";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final_Project.Properties.Resources.Icon_home_white;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Name = "label7";
            // 
            // Alarm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = global::Final_Project.Properties.Resources.black_city_backgrounds_powerpoint;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nummin);
            this.Controls.Add(this.numhour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn24);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alarm";
            ((System.ComponentModel.ISupportInitialize)(this.nummin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numhour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton btn12;
        private System.Windows.Forms.RadioButton btn24;
        private System.Windows.Forms.NumericUpDown nummin;
        private System.Windows.Forms.NumericUpDown numhour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
    }
}