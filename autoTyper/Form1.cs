using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoTyper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "::todolist";
            textBox2.Text = "320";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            System.Windows.Forms.SendKeys.Send(textBox1.Text);
            //System.Windows.Forms.SendKeys.Send("A");
            System.Windows.Forms.SendKeys.Send("{ENTER}");
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = (Convert.ToInt16(textBox2.Text)) * 1000;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
