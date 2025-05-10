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

namespace Restaurant_Manage
{
    public partial class Form1: Form
    {
        DBConnect dbCon = new DBConnect();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            
                try
                {
                    if (txtUsername.Text == String.Empty)
                    {
                        MessageBox.Show("Please enter valid Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Focus();
                        return;
                    }
                    if (txtPassword.Text == String.Empty)
                    {
                        MessageBox.Show("Please enter valid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Focus();
                        return;
                    }
                    if (txtUsername.Text != String.Empty && txtPassword.Text != String.Empty)
                    {
                    //login code
                        SqlCommand cmd = new SqlCommand("Select Username, Password from manage where Username ='" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'", dbCon.GetCon());
                        dbCon.OpenCon();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Login Success");
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password");
                        }
                        dbCon.CloseCon();
                    }
                    else
                    {
                        MessageBox.Show("Please enter Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Clear();
                        txtPassword.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        
    }
}
