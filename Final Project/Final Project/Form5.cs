using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Chessclock : Form
    {
        public Chessclock()
        {
            InitializeComponent();
        }

        int min = 0;
        int sec = 0;
        int mili = 0;
        int min1 = 0;
        int sec1 = 0;
        int mili1 = 0;

        private void btnstart_Click(object sender, EventArgs e)
        {
            if (btnstart.Text == "Start")
            {              
                if (nummin.Value==0 && numsec.Value==0 && numms.Value==0)
                {
                    MessageBox.Show("Please Enter Valid value","Warning");
                }
                else if (nummin.Value > 24 || numsec.Value > 60 || numms.Value > 60)
                {
                    MessageBox.Show("Please Enter Valid value", "Warning");
                }
                else
                {
                    btnswitch1.Visible = true;
                    btnstart.Text = "Pause";
                    timer1.Start();
                    min = Convert.ToInt32(nummin.Value);
                    sec = Convert.ToInt32(numsec.Value);
                    mili = Convert.ToInt32(numms.Value);

                    min1 = Convert.ToInt32(nummin.Value);
                    sec1 = Convert.ToInt32(numsec.Value);
                    mili1 = Convert.ToInt32(numms.Value);
                }
            }
            else if (btnstart.Text == "Pause")
            {
                btnstart.Text = "Cont..";
                timer1.Stop();
                timer2.Stop();

                if (btnswitch1.Visible==true)
                {
                    btnswitch1.Text = "Reset";
                }
                else if (btnswitch2.Visible==true)
                {
                    btnswitch2.Text = "Reset";
                }

                
            }
            else if (btnstart.Text=="Cont..")
            {
                btnstart.Text = "Pause";
                if (btnswitch1.Text=="Reset")
                {
                    timer1.Start();
                    btnswitch1.Text = "Switch";
                }
                else if (btnswitch2.Text=="Reset")
                {
                    timer2.Start();
                    btnswitch2.Text = "Switch";
                }
            }
        }

        private void btnswitch1_Click(object sender, EventArgs e)
        {
            if (btnswitch1.Text == "Switch")
            {
                timer1.Stop();
                timer2.Start();
                btnswitch1.Visible = false;
                btnswitch2.Visible = true;
            }
            else if (btnswitch1.Text=="Reset")
            {
                 btnswitch1.Visible = false;
                 btnswitch1.Text = "Switch";
                 btnswitch2.Text = "Switch";
                 btnstart.Text = "Start";
                 btnstart.Visible = true;
                 btnswitch2.Visible = false;
                 timer1.Stop();
                 timer2.Stop();
                 nummin.Value = 0;
                 numsec.Value = 0;
                 numms.Value = 0;
                 lblmin.Text = "00";
                 lblsec.Text = "00";
                 lblms.Text = "00";

                 lblmin1.Text = "00";
                 lblsec1.Text = "00";
                 lblms1.Text = "00";
                 
            }
        }

        private void btnswitch2_Click(object sender, EventArgs e)
        {
            if (btnswitch2.Text == "Switch")
            {
                timer2.Stop();
                timer1.Start();
                btnswitch2.Visible = false;
                btnswitch1.Visible = true;
            }
            else if (btnswitch2.Text == "Reset")
            {
                btnswitch1.Text = "Switch";
                btnswitch2.Text = "Switch";
                btnstart.Text = "Start";
                btnswitch1.Visible = false;
                btnswitch2.Visible = false;
                btnstart.Visible = true;
                timer1.Stop();
                timer2.Stop();
                nummin.Value = 0;
                numsec.Value = 0;
                numms.Value = 0;
                lblmin.Text = "00";
                lblsec.Text = "00";
                lblms.Text = "00";

                lblmin1.Text = "00";
                lblsec1.Text = "00";
                lblms1.Text = "00";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mili = mili - 1;
            if (mili == -1)
            {
                sec = sec - 1;
                mili = 59;
            }
            if (sec == -1)
            {
                min = min - 1;
                sec = 59;
            }
            if (mili == 0 && sec == 0 && min == 0)
            {
                timer1.Stop();
                timer2.Stop();           
                MessageBox.Show("You Lose Player1", "Warning");
                btnswitch1.Text = "Reset";
                btnswitch2.Text = "Reset";
                btnstart.Text = "Start";
                btnstart.Visible = false;
                
                
               
            }

            string ml = Convert.ToString(mili);
            string ss = Convert.ToString(sec);
            string mm = Convert.ToString(min);

            lblmin.Text = mm;
            lblsec.Text = ss;
            lblms.Text = ml;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            mili1 = mili1 - 1;
            if (mili1 == -1)
            {
                sec1 = sec1 - 1;
                mili1 = 59;
            }
            if (sec1 == -1)
            {
                min1 = min1 - 1;
                sec1 = 59;
            }
            if (mili1 == 0 && sec1 == 0 && min1 == 0)
            {
                timer1.Stop(); 
                timer2.Stop();

                MessageBox.Show("You Lose Player2", "Warning");
                btnswitch1.Text = "Reset";
                btnswitch2.Text = "Reset";
                btnstart.Text = "Start";
                btnstart.Visible = false;
                
                
               
            }
            string ml1 = Convert.ToString(mili1);
            string ss1 = Convert.ToString(sec1);
            string mm1 = Convert.ToString(min1);

            lblmin1.Text = mm1;
            lblsec1.Text = ss1;
            lblms1.Text = ml1;
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            this.Hide();
            mainpage main = new mainpage();
            main.Show();
        }

            

    }
}
