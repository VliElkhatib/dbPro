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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=CarRental;Trusted_Connection=True;");

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            UserIdTb.Text = "";
            UpassTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select count(*) from UserTable where username='" + UserIdTb.Text + "' and password='" + UpassTb.Text + "'";
            Con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter(query,Con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            if(dt.Rows[0][0].ToString()=="1" )
            {
                MainForm mainform = new MainForm();
                mainform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username Or Password");
            }
            Con.Close();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
