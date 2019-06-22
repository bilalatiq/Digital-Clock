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
    public partial class Countdown : Form
    {
        public Countdown()
        {
            InitializeComponent();
        }

        int hour = 0;
        int min = 0;
        int sec = 0;


        private void btnstart_Click(object sender, EventArgs e)
        {
            if (btnstart.Text == "Start")
            {
                if (numhour.Value == 0 && nummin.Value == 0 && numsec.Value == 0)
                {
                    MessageBox.Show("Please Enter Any value", "Warning");
                    
                }
                else if (numhour.Value>24 || nummin.Value>60 || numsec.Value>60)
                {
                    MessageBox.Show("Please Enter Valid value", "Warning");                  
                }
                else
                {
                    btnstart.Text = "Stop";
                    timer1.Start();
                    hour = Convert.ToInt32(numhour.Value);
                    min = Convert.ToInt32(nummin.Value);
                    sec = Convert.ToInt32(numsec.Value);
                }
            }
            else if (btnstart.Text=="Stop")
            {
                timer1.Stop();
                btnreset.Visible = true;
                btnstart.Text = "Cont..";
            }
            else if (btnstart.Text=="Cont..")
            {
                timer1.Start();
                btnstart.Text = "Stop";
                btnreset.Visible = false;
            }
       }


        private void btnreset_Click(object sender, EventArgs e)
        {
            lblhour.Text = "00";
            lblmin.Text = "00";
            lblsec.Text = "00";
            btnreset.Visible = false;
            btnstart.Text = "Start";
            numhour.Value = 0;
            nummin.Value = 0;
            numsec.Value = 0;
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            sec = sec - 1;
            if (sec == -1)
            {
                min = min - 1;
                sec = 59;
            }
            if (min == -1)
            {
                hour = hour - 1;
                min = 59;
            }
            if (hour == 0 && min == 0 && sec == 0)
            {
                timer1.Stop();
                MessageBox.Show("Time's up!!!!!!!", "Warning");
                lblhour.Text = "00";
                lblmin.Text = "00";
                lblsec.Text = "00";
                btnreset.Visible = false;
                btnstart.Text = "Start";
                numhour.Value = 0;
                nummin.Value = 0;
                numsec.Value = 0;
                

            }

            string hh = Convert.ToString(hour);
            string mm = Convert.ToString(min);
            string ss = Convert.ToString(sec);
            lblhour.Text = hh;
            lblmin.Text = mm;
            lblsec.Text = ss;
        }
 
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            mainpage main = new mainpage();
            main.Show();
        }

       
        


    }
}
