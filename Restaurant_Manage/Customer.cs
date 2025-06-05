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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Restaurant_Manage
{
    public partial class Customer: Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MURIEL\SQLEXPRESS;Initial Catalog=RestMangDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into customertab values(@customerid,@name,@phone,@email)", con);
            cmd.Parameters.AddWithValue("@CustomerID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Phone", textBox3.Text);
            cmd.Parameters.AddWithValue("@Email", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MURIEL\SQLEXPRESS;Initial Catalog=RestMangDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from customertab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MURIEL\SQLEXPRESS;Initial Catalog=RestMangDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update customertab set name=@name, phone=@phone, email=@email where customerid=@customerid", con);
            cmd.Parameters.AddWithValue("@CustomerID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Phone", textBox3.Text);
            cmd.Parameters.AddWithValue("@Email", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MURIEL\SQLEXPRESS;Initial Catalog=RestMangDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete customertab where customerid=@customerid", con);
            cmd.Parameters.AddWithValue("@CustomerID", int.Parse(textBox1.Text));

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MURIEL\SQLEXPRESS;Initial Catalog=RestMangDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from customertab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MURIEL\SQLEXPRESS;Initial Catalog=RestMangDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from customertab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
