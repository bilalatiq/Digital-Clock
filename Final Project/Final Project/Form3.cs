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
    public partial class stopwatch : Form
    {
        public stopwatch()
        {
            InitializeComponent();
        }
        int scnd = 0;
        int mint = 0;
        int hr = 0;
        int mils = 0;
        int counter = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            mils = mils + 01;
            if (mils == 60)
            {
                scnd = scnd + 01;
                mils = 0;
            }
            if (scnd == 61)
            {
                mint = mint + 01;
                scnd = 0;
            }
            if (mint == 61)
            {
                hr = hr + 01;
                mint = 0;
            }

            string hh = Convert.ToString(hr);
            string mm = Convert.ToString(mint);
            string ss = Convert.ToString(scnd);
            string mis = Convert.ToString(mils);

            lblhour.Text = hh;
            lblmin.Text = mm;
            lblsec.Text = ss;
            lblms.Text = mis;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (btnstart.Text=="Start")
            {
                timer1.Start();
                btnstart.Text = "Stop";
                btnlap.Visible = true;
                btnlap.Text = "Lap";
            }
            else if (btnstart.Text=="Stop")
            {
                timer1.Stop();
                btnlap.Visible = false;
                btnstart.Text = "Cont..";
                btnlap.Text = "Reset";
                btnlap.Visible = true;
            }
            else if (btnstart.Text=="Cont..")
            {
                timer1.Start();
                btnstart.Text = "Stop";
                btnlap.Text = "Lap";
                btnlap.Visible = true;
            }
            

        }

        private void btnlap_Click(object sender, EventArgs e)
        {
            if (btnlap.Text=="Lap")
            {

                this.listBox1.Items.Add(counter + ":   " + lblhour.Text + ":" + lblmin.Text + ":" + lblsec.Text + ":" + lblms.Text);
                counter++;
            }
            else if (btnlap.Text=="Reset")
            {
                btnstart.Text = "Start";
                listBox1.Items.Clear();
                abc();
                btnlap.Text = "Lap";
                btnlap.Visible = false;
            }
            
        }

        public void abc()
        {
            mils = 0;
            scnd = 0;
            mint = 0;
            hr = 0;
            counter = 1;
            string hh = Convert.ToString(hr);
            string mm = Convert.ToString(mint);
            string ss = Convert.ToString(scnd);
            string mis = Convert.ToString(mils);

            lblhour.Text = hh;
            lblmin.Text = mm;
            lblsec.Text = ss;
            lblms.Text = mis;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainpage main = new mainpage();
            main.Show();
        }

        
    }
}
