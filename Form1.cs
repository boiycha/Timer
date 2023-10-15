using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pause_Play
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }

        int c = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            c++;
            label1.Text = c.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                button1.Text = "Resume";
            }
            else
            {
                timer1.Enabled = true;
                button1.Text = "Pause";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Start";
            label1.Text = "0";
            button2.Text = "Stop";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button1.Text = "Start";
            label1.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
