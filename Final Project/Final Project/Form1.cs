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
    public partial class mainpage : Form
    {
        public mainpage()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            digitalclock digital = new digitalclock();
            digital.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            stopwatch stopwch = new stopwatch();
            stopwch.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Countdown countdn  = new Countdown();
            countdn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chessclock chesscl = new Chessclock();
            chesscl.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alarm al = new Alarm();
            al.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
