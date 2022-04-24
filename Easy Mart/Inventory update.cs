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
    public partial class Inventory_update : Form
    {
        int itmcde, qnty, price;
        string itmnme, ctrgy;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\EmartDB\EmartDB.mdf;Integrated Security=True;Connect Timeout=30");
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='F:\Learn\c#\Easy Mart\Easy Mart\easymartDB.mdf';Integrated Security=True;Connect Timeout=30");
        public Inventory_update()
        {
            InitializeComponent();
        }

        private void Inventory_update_Load(object sender, EventArgs e)
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            itmcde = int.Parse(txtitemcode.Text);
            qnty = int.Parse(txtquantity.Text);
            price = int.Parse(txtunitprice.Text);
            int newqnty,prevqnty;
            // fetching data from the database to update the quantity

            string SelectSql = "SELECT quantity FROM inventory WHERE itemcode = '" + itmcde + "'";
            SqlCommand comsel = new SqlCommand(SelectSql, con);
            try
            {
                con.Open();
                using (SqlDataReader read = comsel.ExecuteReader())
                {
                    while (read.Read())
                    {
                        lblqnty.Text = (read["quantity"].ToString());
                        prevqnty = int.Parse(lblqnty.Text);
                        

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }


            //end of updating

            prevqnty = int.Parse(lblqnty.Text);
            newqnty = prevqnty + qnty;
            string update = "UPDATE inventory SET quantity = '" + newqnty + "', unitprice = '" + price + "' WHERE  itemcode = '" + itmcde + "' ";
            SqlCommand upcmd = new SqlCommand(update, con);
            try
            {
                con.Open();
                upcmd.ExecuteNonQuery();
                MessageBox.Show("item " + itmcde + " successfully updated");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            txtitemcode.Text = "";
            txtquantity.Text = "";
            txtunitprice.Text = "";
            txtitemname.Text = "";
            rbtnbeverages.Checked = false;
            rbtnfood.Checked = false;
            rbtnvegetables.Checked = false;
            lblqnty.Text = "";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            itmcde = int.Parse(txtitemcode.Text);
            string del = "DELETE FROM inventory WHERE itemcode ='" + itmcde + "'";
            SqlCommand cmddel = new SqlCommand(del, con);
            try
            {
                con.Open();
                cmddel.ExecuteNonQuery();
                MessageBox.Show("item " + itmcde + " removed from the inventory successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            txtitemcode.Text = "";
            txtquantity.Text = "";
            txtunitprice.Text = "";
            txtitemname.Text = "";
            rbtnbeverages.Checked = false;
            rbtnfood.Checked = false;
            rbtnvegetables.Checked = false;
            lblqnty.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {
            itmcde = int.Parse(txtitemcode.Text);
            qnty = int.Parse(txtquantity.Text);
            price = int.Parse(txtunitprice.Text);
            itmnme = txtitemname.Text;
            if (rbtnvegetables.Checked)
            {
                ctrgy = "V";
            }
            else if
                (rbtnbeverages.Checked)
            {
                ctrgy = "B";
            }
            else if
                (rbtnfood.Checked)
            {
                ctrgy = "F";
            }


            string addnew = "INSERT INTO inventory VALUES ('" + itmcde + "','" + itmnme + "','" + ctrgy + "','" + qnty + "','" + price + "')";
            SqlCommand adnw = new SqlCommand(addnew, con);

            try
            {
                con.Open();
                adnw.ExecuteNonQuery();
                MessageBox.Show("New item " + itmnme + " is succesfully added");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }
            txtitemcode.Text = "";
            txtquantity.Text = "";
            txtunitprice.Text = "";
            txtitemname.Text = "";
            rbtnbeverages.Checked = false;
            rbtnfood.Checked = false;
            rbtnvegetables.Checked = false;
            lblqnty.Text = "";
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            txtitemcode.Text = "";
            txtquantity.Text = "";
            txtunitprice.Text = "";
            txtitemname.Text = "";
            rbtnbeverages.Checked = false;
            rbtnfood.Checked = false;
            rbtnvegetables.Checked = false;
            lblqnty.Text = "";
        }
    }
}
