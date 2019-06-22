using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Final_Project
{
    public partial class Alarm : Form
    {
        public Alarm()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (btn12.Checked == true)
            {
                if (numhour.Value == Convert.ToInt32(DateTime.Now.ToString("hh")) && nummin.Value == Convert.ToInt32(DateTime.Now.ToString("mm")))
                {
                    if (checkBox1.Checked = true && DateTime.Now.ToString("tt") == checkBox1.Text)
                    {
                        if (comboBox1.Text == "Tone1")
                        {
                            timer1.Stop();
                            SoundPlayer splay = new SoundPlayer(Final_Project.Properties.Resources.tone1);
                            splay.Play();
                            MessageBox.Show("Times up!!!!");
                            label7.Visible = false;
                            splay.Stop();
                        }
                        else if (comboBox1.Text == "Tone2")
                        {
                            timer1.Stop();
                            SoundPlayer splay = new SoundPlayer(Final_Project.Properties.Resources.tone2);
                            splay.Play();
                            MessageBox.Show("Times up!!!!");
                            label7.Visible = false;
                            splay.Stop();
                        }
                    }
                    else if (checkBox2.Checked = true && DateTime.Now.ToString("tt") == checkBox2.Text)
                    {
                        if (comboBox1.Text == "Tone1")
                        {
                            timer1.Stop();
                            SoundPlayer splay = new SoundPlayer(Final_Project.Properties.Resources.tone1);
                            splay.Play();
                            MessageBox.Show("Times up!!!!");
                            label7.Visible = false;
                            splay.Stop();
                        }
                        else if (comboBox1.Text == "Tone2")
                        {
                            timer1.Stop();
                            SoundPlayer splay = new SoundPlayer(Final_Project.Properties.Resources.tone2);
                            splay.Play();
                            MessageBox.Show("Times up!!!!");
                            label7.Visible = false;
                            splay.Stop();
                        }
                    }
                }
            }
            else if (btn24.Checked == true)
            {            
                if (numhour.Value == Convert.ToInt32(DateTime.Now.ToString("HH")) && nummin.Value == Convert.ToInt32(DateTime.Now.ToString("mm")))
                {
                    if (comboBox1.Text == "Tone1")
                    {
                        timer1.Stop();
                        SoundPlayer splay = new SoundPlayer(Final_Project.Properties.Resources.tone1);
                        splay.Play();
                        MessageBox.Show("Times up!!!!");
                        label7.Visible = false;
                        splay.Stop();
                    }
                    else if (comboBox1.Text == "Tone2")
                    {
                        timer1.Stop();
                        SoundPlayer splay = new SoundPlayer(Final_Project.Properties.Resources.tone2);
                        splay.Play();
                        MessageBox.Show("Times up!!!!");
                        label7.Visible = false;
                        splay.Stop();
                    }
                }
            }
        }
         
        

        private void btnset_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            timer1.Start();

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            numhour.Value = 0;
            nummin.Value = 0;
            this.Hide();
            mainpage main = new mainpage();
            main.Show();
        }
    }
}
