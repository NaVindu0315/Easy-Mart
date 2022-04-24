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
    public partial class sales : Form
    {
        int itemcde, empcode, quantity, total, recieved, balance,intventafter;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\EmartDB\EmartDB.mdf;Integrated Security=True;Connect Timeout=30");
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='F:\Learn\c#\Easy Mart\Easy Mart\easymartDB.mdf';Integrated Security=True;Connect Timeout=30");
        public sales()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sales_Load(object sender, EventArgs e)
        {

        }

        private void btnbalance_Click(object sender, EventArgs e)
        {
            recieved = int.Parse(txtrecieved.Text);
            balance = recieved - total;
            lblbalanc.Text = balance.ToString();

            string sales = "INSERT INTO sales (empid,itemcode,quantity,total) VALUES('" + empcode + "','" + itemcde + "','" + quantity + "','" + total + "')";
            //NaVindu LakShan
            SqlCommand sell = new SqlCommand(sales, con);
            try
            {
                con.Open();
                sell.ExecuteNonQuery();
                MessageBox.Show("Next Customer Please");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }

            string inventcheck = "SELECT quantity FROM inventory WHERE itemcode = '" + itemcde + "'";
            SqlCommand inchck = new SqlCommand(inventcheck, con);
            try
            {
                con.Open();
                using (SqlDataReader read = inchck.ExecuteReader())
                {
                    while (read.Read())
                    {
                        lblinvent.Text = (read["quantity"].ToString());
                        int inventory = int.Parse(lblinvent.Text);
                        intventafter = inventory - quantity;
                        if (intventafter <= 3)
                        {
                            MessageBox.Show("item " + itemcde + " running out of stocks ");
                        }


                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("item " + itemcde + " is running out of stocks");
            }
            finally
            {
                con.Close();
            }

            string update = "UPDATE inventory SET quantity = '" + intventafter + "' WHERE itemcode = '"+itemcde+"' ";
            SqlCommand upinti = new SqlCommand(update, con);
            try
            {
                con.Open();
                upinti.ExecuteNonQuery();
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            txtrecieved.Text = "";
            txtquantity.Text = "";
            txtitemcode.Text = "";
            txtempcode.Text = "";
            lblbalanc.Text = "";
            lbltotal.Text = "";
            lblinvent.Text = "";
            lblitemprice.Text = "";
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 log = new Form2();
            log.Show();
            this.Hide();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtrecieved.Text = "";
            txtquantity.Text = "";
            txtitemcode.Text = "";
            txtempcode.Text = "";
            lblbalanc.Text = "";
            lbltotal.Text = "";
            lblinvent.Text = "";
            lblitemprice.Text = "";
        }

        private void btntotal_Click(object sender, EventArgs e)
        {
            itemcde = int.Parse(txtitemcode.Text);
            empcode = int.Parse(txtempcode.Text);
            quantity = int.Parse(txtquantity.Text);
            
            string SelectSql = "SELECT unitprice FROM inventory WHERE itemcode = '"+itemcde+"'";
            SqlCommand comsel = new SqlCommand(SelectSql, con);
            try
            {
                con.Open();
                using (SqlDataReader read = comsel.ExecuteReader())
                {
                    while (read.Read())
                    {
                        lblitemprice.Text = (read["unitprice"].ToString());
                       
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            int unitprice = int.Parse(lblitemprice.Text);
            total = quantity * unitprice;
            lbltotal.Text = total.ToString();

           
        }
    }
}
