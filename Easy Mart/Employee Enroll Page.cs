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
    public partial class Employee_Enroll_Page : Form
    {
        int emid, tell;
        string fname, ses, adrs, ni, sing;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\EmartDB\EmartDB.mdf;Integrated Security=True;Connect Timeout=30");
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='F:\Learn\c#\Easy Mart\Easy Mart\easymartDB.mdf';Integrated Security=True;Connect Timeout=30");
        public Employee_Enroll_Page()
        {
            InitializeComponent();
        }

        private void Employee_Enroll_Page_Load(object sender, EventArgs e)
        {

        }

        private void txtempid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnic_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Form3 bckhome = new Form3();
            bckhome.Show();
            this.Hide();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 bckhome = new Form3();
            bckhome.Show();
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            emid = int.Parse(txtempid.Text);
            fname = txtname.Text;
            ni = txtnic.Text;
            string dt = txtdob.Text;
            if (radioBtnf.Checked)
            {
                ses = "Female";
            }
            else
            {
                ses = "Male";
            }
            if (wins.Checked)
            {
                sing = "Married";
            }
            else
            {
                sing = "Single";
            }
            adrs = txtaddress.Text;
            tell = int.Parse(txttelno.Text);

            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Learn\c#\Supermarket\supermarketdb.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "INSERT INTO employee VALUES ('" + emid + "','" + fname + "','" + ni + "','" + dt + "','" + ses + "','" + sing + "','" + adrs + "','" + tell + "')";
            //string qry = "INSERT INTO employee VALUES ('100','navindu','20000','2000/03/15','male','single','sdfsddf','32131')";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Added successsfully");
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            txtaddress.Text = "";

            txtempid.Text = "";
            txtname.Text = "";
            txtnic.Text = "";
            txttelno.Text = "";
            radioBtnf.Checked = false;
            radioBtnM.Checked = false;
            txtdob.Text = "";
            wins.Checked = false;

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            emid = int.Parse(txtempid.Text);
            if
                (wins.Checked)
            {
                sing = "Married";
            }
            else
            {
                sing = "single";
            }
            adrs = txtaddress.Text;
            tell = int.Parse(txttelno.Text);

            string update = "UPDATE employee SET civil = '" + sing + "', address ='"+adrs+"' , tel = '"+tell+"'";
            SqlCommand upcmd = new SqlCommand(update, con);
            try
            {
                con.Open();
                upcmd.ExecuteNonQuery();
                MessageBox.Show("employee "+emid + " is succesfully updated" );
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                con.Close();
            }
            txtaddress.Text = "";

            txtempid.Text = "";
            txtname.Text = "";
            txtnic.Text = "";
            txttelno.Text = "";
            radioBtnf.Checked = false;
            radioBtnM.Checked = false;
            txtdob.Text = "";
            wins.Checked = false;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            emid = int.Parse(txtempid.Text);
            string del = "DELETE FROM employee WHERE empid='"+emid+"'";
            SqlCommand cmddel = new SqlCommand(del, con);
            try
            {
                con.Open();
                cmddel.ExecuteNonQuery();
                MessageBox.Show("employee " + emid + " is deleted from the records");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            txtaddress.Text = "";

            txtempid.Text = "";
            txtname.Text = "";
            txtnic.Text = "";
            txttelno.Text = "";
            radioBtnf.Checked = false;
            radioBtnM.Checked = false;
            txtdob.Text = "";
            wins.Checked = false;
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            txtaddress.Text = "";

            txtempid.Text = "";
            txtname.Text = "";
            txtnic.Text = "";
            txttelno.Text = "";
            radioBtnf.Checked = false;
            radioBtnM.Checked = false;
            txtdob.Text = "";
            wins.Checked = false;
        }

        private void label7_Click(object sender, EventArgs e)
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
