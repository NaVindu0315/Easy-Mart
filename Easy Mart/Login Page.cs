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
    public partial class Form2 : Form
    {
        string username, pwd;
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Form1 bckop = new Form1();
            bckop.Show();
            this.Hide();

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            sales sel = new sales();
            sel.Show();
            this.Hide();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            /*username = txtusername.Text;
            pwd = txtpwd.Text;
            Form3 wel = new Form3();
            wel.Show();
            this.Hide();*/
            username = txtusername.Text;
            pwd = txtpwd.Text;
            if
                (winsw.Checked) //for admins
            {
                //username checking
                if
                    (username=="admin")
                {
                    //pwd checking 
                    if
                        (pwd == "admin123")
                    {
                        Form3 weladmin = new Form3();
                        weladmin.Show();
                        this.Hide();
                    }
                    else
                    //invalid admin pwd
                    {
                        MessageBox.Show("invalid password");
                        txtpwd.Text = "";
                        txtusername.Text = "";
                    }

                }
                else
                //invalid username
                {
                    MessageBox.Show("invalid admin username");
                    txtpwd.Text = "";
                    txtusername.Text = "";
                }


            }
            else //for sellers
            {
                //seller user name checking
                if
                    (username=="seller")
                {
                    //pwd checking
                    if
                        (pwd=="seller123")
                    {
                        sales sel = new sales();
                        sel.Show();
                        this.Hide();
                    }
                    else
                    //invalid pwd
                    {
                        MessageBox.Show("invalid password");
                        txtpwd.Text = "";
                        txtusername.Text = "";
                    }
                }
                else
                //invalid username
                {
                    MessageBox.Show("Invalid username");
                    txtpwd.Text = "";
                    txtusername.Text = "";
                }
            }
        }
    }
}
