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
    public partial class devloading : Form
    {
        int x;
        public devloading()
        {
            InitializeComponent();
        }

        private void devloading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = x + 5;
            gunaProgressBar1.Value = x;
            if(gunaProgressBar1.Value == 100)
            {
                timer1.Stop();
                developers dev = new developers();
                dev.Show();
                this.Hide();

            }
        }
    }
}
