using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_Mart
{
    public partial class loding : Form
    {
        int x;
        public loding()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x=x+5;
            gunaCircleProgressBar1.Value = x;
            if
                (gunaCircleProgressBar1.Value ==100)
            {
                timer1.Stop();
                Form1 opn = new Form1();
                opn.Show();
                this.Hide();
            }

            gunaProgressBar1.Value = x;
            if
                (gunaProgressBar1.Value==100)
                {
                timer1.Stop();

                }
        }

        private void loding_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void gunaCircleProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
