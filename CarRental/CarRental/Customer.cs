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

namespace CarRental
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=CarRental;Trusted_Connection=True;");
        private void populate()
        {
            Con.Open();
            string query = "select * from CustomerTable";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CustomerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "" || NameTb.Text == "" || AddresslTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into CustomerTable values('" + IdTb.Text + "','" + NameTb.Text + "','" + AddresslTb.Text + "','" + PhoneTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Succsessfully Added");
                    Con.Close();
                    populate();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from CustomerTable where CustomerId='" + IdTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Deleted");
                    Con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "" || NameTb.Text == "" || AddresslTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update CustomerTable set CustomerName='" + NameTb.Text + "',CustomerAddress='" + AddresslTb.Text + "',Phone = '" + PhoneTb.Text + "' where CustomerId='" + IdTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Succsessfully Updated");
                    Con.Close();
                    populate();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
