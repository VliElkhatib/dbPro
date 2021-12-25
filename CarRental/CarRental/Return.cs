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
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=CarRental;Trusted_Connection=True;");
        private void populate()
        {
            Con.Open();
            string query = "select * from RentalTable";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RentalDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void populateRet()
        {
            Con.Open();
            string query = "select * from ReturnTable";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReturnDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void DeleteOnReturn()
        {
            int RentId;
            RentId = Convert.ToInt32(RentalDGV.SelectedRows[0].Cells[0].Value.ToString());
            Con.Open();
            string query = "delete from RentalTable where RentId=" + RentId + ";";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Rental Successfully Deleted");
            Con.Close();
            populate();
            // UpdateonRentDelete();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void Return_Load(object sender, EventArgs e)
        {
            populate();
            populateRet();

        }

        private void RentalDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //CarIdTb.Text = RentalDGV.SelectedRows[0].Cells[1].Value.ToString();
            // CustNameTb.Text = RentalDGV.SelectedRows[0].Cells[2].Value.ToString();

            DateTime d1 = ReturnDate.Value.Date;
            DateTime d2 = DateTime.Now;
            TimeSpan t = d2 - d1;
            int NrOfDays = Convert.ToInt32(t.TotalDays);

            if (NrOfDays <= 0)
            {
                DelayTb.Text = "No Delay";
                FineTb.Text = "No Fine";
            }
            else
            {
                DelayTb.Text = "" + NrOfDays;
                FineTb.Text = "" + (NrOfDays * 250);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "" || CustNameTb.Text == "" || FineTb.Text == "" || DelayTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into ReturnTable values('" + IdTb.Text + "'," + CarIdTb.Text + ",'" + CustNameTb.Text + "','" + ReturnDate.Text + "','" + DelayTb.Text + "'," + FineTb.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Returned");
                    Con.Close();
                    // UpdateonRent();
                    populateRet();
                    DeleteOnReturn();


                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
