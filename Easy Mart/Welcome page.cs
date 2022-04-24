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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            Form1 bckop = new Form1();
            bckop.Show();
            this.Hide();

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 bckhome = new Form3();
            bckhome.Show();
            this.Hide();
        }

        private void inventoryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void foodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 foodint = new Form4();
            foodint.Show();
            this.Hide();

        }

        private void vegetablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 vegint = new Form5();
            vegint.Show();
            this.Hide();
        }

        private void beverageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 bevint = new Form6();
            bevint.Show();
            this.Hide();
        }

        private void purchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory_update upint = new Inventory_update();
            upint.Show();
            this.Hide();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Enroll_Page empenroll = new Employee_Enroll_Page();
            empenroll.Show();
            this.Hide();

        }

        private void enrollNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employee emp = new employee();
            emp.Show();
            this.Hide();
        }

        private void saleReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sales_report slrep = new sales_report();
            slrep.Show();
            this.Hide();
        }

        private void saleFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sales sell = new sales();
            sell.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 foodint = new Form4();
            foodint.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 vegint = new Form5();
            vegint.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 bevint = new Form6();
            bevint.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Inventory_update upint = new Inventory_update();
            upint.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Inventory_update upint = new Inventory_update();
            upint.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Inventory_update upint = new Inventory_update();
            upint.Show();
            this.Hide();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            employee emp = new employee();
            emp.Show();
            this.Hide();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {


            Employee_Enroll_Page empenroll = new Employee_Enroll_Page();
            empenroll.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            sales_report sell = new sales_report();
            sell.Show();
            this.Hide();
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            devloading dev = new devloading();
            dev.Show();
            this.Hide();

        }
    }
}
