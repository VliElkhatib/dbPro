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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

       // SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-8LHGD9B;Initial Catalog=CarRental;Integrated Security=True");
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=CarRental;Trusted_Connection=True;");
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void populate()
        {
            Con.Open();
            string query = "select * from UserTable";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            UserDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Uid.Text == "" || Uname.Text == "" || Upass.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into UserTable values('" + Uid.Text + "','" + Uname.Text + "','" + Upass.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Succsessfully Added");
                    Con.Close();
                    populate();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Uid.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from UserTable where id="+Uid.Text+";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Deleted");
                    Con.Close();
                    populate();
                } catch(Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Uid.Text = UserDGV.SelectedRows[0].Cells[0].Value.ToString();
            //Uname.Text = UserDGV.SelectedRows[0].Cells[1].Value.ToString();
            //Upass.Text = UserDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Uid.Text == "" || Uname.Text == "" || Upass.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update UserTable set username='"+Uname.Text+"',password='"+Upass.Text+"' where id="+Uid.Text+";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Succsessfully Updated");
                    Con.Close();
                    populate();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void Uid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Upass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Uname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
