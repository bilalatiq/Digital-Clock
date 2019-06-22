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
    public partial class digitalclock : Form
    {
        public digitalclock()
        {
            InitializeComponent();
            btn12.Checked = true;
            btn24.Checked = false;
        }

        private void digitalclock_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time12.Text = DateTime.Now.ToString("hh:mm:ss");
            AmPm.Text = DateTime.Now.ToString(":tt");
            time24.Text = DateTime.Now.ToString("HH : mm : ss");
            date.Text = DateTime.Now.ToString("MMM dd yyyy");
            day.Text = DateTime.Now.ToString("dddd");
           
        }

        private void btn12_CheckedChanged(object sender, EventArgs e)
        {
            AmPm.Visible = true;
            time12.Visible = true;
            time24.Visible = false;
        }

        private void btn24_CheckedChanged(object sender, EventArgs e)
        {
            AmPm.Visible = false;
            time24.Visible = true;
            time12.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainpage main = new mainpage();
            main.Show();
        }
    }
}
      
               
            
     