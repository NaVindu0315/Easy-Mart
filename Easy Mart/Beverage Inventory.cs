using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Easy_Mart
{
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\EmartDB\EmartDB.mdf;Integrated Security=True;Connect Timeout=30");
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='F:\Learn\c#\Easy Mart\Easy Mart\easymartDB.mdf';Integrated Security=True;Connect Timeout=30");
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 bevint = new Form6();
            bevint.Show();
            this.Hide();
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

        private void foodToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnupfood_Click(object sender, EventArgs e)
        {
            Inventory_update upint = new Inventory_update();
            upint.Show();
            this.Hide();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Form3 bckhome = new Form3();
            bckhome.Show();
            this.Hide();
        }

        private void inventoryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            string qryy = "SELECT itemcode,name,quantity,unitprice FROM inventory WHERE category='B'";
            SqlDataAdapter adapter = new SqlDataAdapter(qryy, con);
            DataSet set = new DataSet();
            adapter.Fill(set, "inventory");
            dataGridView1.DataSource = set.Tables["inventory"];
        }
    }
}
