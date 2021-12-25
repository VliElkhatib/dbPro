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
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=CarRental;Trusted_Connection=True;");
        private void populate()
        {
            Con.Open();
            string query = "select * from CarTable";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CarDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RegNoTb.Text == "" || BrandTb.Text == "" || ModelTb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into CarTable values('" + RegNoTb.Text + "','" + BrandTb.Text + "','" + ModelTb.Text + "',"+PriceTb.Text+ ",'" + AvailableCb.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Succsessfully Added");
                    Con.Close();
                    populate();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void Car_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RegNoTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from CarTable where RegNum='" + RegNoTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Deleted");
                    Con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void CarDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // RegNoTb.Text = CarDGV.SelectedRows[0].Cells[0].Value.ToString();
           // BrandTb.Text = CarDGV.SelectedRows[0].Cells[1].Value.ToString();
           // ModelTb.Text = CarDGV.SelectedRows[0].Cells[2].Value.ToString();
           // AvailableCb.SelectedItem = CarDGV.SelectedRows[0].Cells[3].Value.ToString();
           // PriceTb.Text = CarDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (RegNoTb.Text == "" || BrandTb.Text == "" || ModelTb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update CarTable set Brand='" + BrandTb.Text + "',Model='" + ModelTb.Text + "',Available = '"+AvailableCb.SelectedItem.ToString()+"',Price = '"+PriceTb.Text+"' where RegNum='"+RegNoTb.Text+"';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Succsessfully Updated");
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
    }
}
