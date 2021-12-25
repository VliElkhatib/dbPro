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
    public partial class Rental : Form
    {
        public Rental()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=CarRental;Trusted_Connection=True;");

        private void fillcombo()
        {
            Con.Open();
            string query = "select  RegNum from CarTable where Available='"+"Yes"+"'";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RegNum", typeof(string));
            dt.Load(rdr);
            CarRegCb.ValueMember = "RegNum";
            CarRegCb.DataSource = dt;
            Con.Close();
        }
        private void fillCustomer()
        {
            Con.Open();
            string query = "select CustomerId from CustomerTable";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustomerId", typeof(string));
            dt.Load(rdr);
            CustCb.ValueMember = "CustomerId";
            CustCb.DataSource = dt;
            Con.Close();
        }

        private void fetchCustName()
        {
            Con.Open();
            string query = "select * from CustomerTable where CustomerId = " + CustCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                CustNameTb.Text = dr["CustomerName"].ToString();

            }
            Con.Close();
        }
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //DateTime.Now.ToString("yyyy-mm-dd");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Rental_Load(object sender, EventArgs e)
        {
            fillcombo();
            fillCustomer();
            populate();
        }

        private void UpdateonRent()
        {
            Con.Open();
            string query = "update CarTable set Available = '" + "Yes" + "' where RegNum='" + CarRegCb.SelectedValue.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Car Succsessfully Updated");
            Con.Close();
        }

        private void UpdateonRentDelete()
        {
            Con.Open();
            string query = "update CarTable set Available = '" + "No" + "' where RegNum='" + CarRegCb.SelectedValue.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Car Succsessfully Updated");
            Con.Close();
        }

        private void CarRegCb_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void CustCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchCustName();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "" || CustNameTb.Text == "" || FeesTb.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into RentalTable values('" + IdTb.Text + "','" +CarRegCb.SelectedValue.ToString()+ "','" + CustNameTb.Text + "','" + RentDate.Text + "','"+ReturnDate.Text+"',"+FeesTb.Text+")";
                    SqlCommand cmd = new SqlCommand(query, Con);               
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Succsessfully Rented");
                    Con.Close();
                    UpdateonRent(); 
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

        private void ReturnDate_ValueChanged(object sender, EventArgs e)
        {
            //DateTime.Now.ToString("yyyy-mm-dd");
        }

        private void FeesTb_TextChanged(object sender, EventArgs e)
        {

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
                    string query = "delete from RentalTable where RentId=" + IdTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rental Successfully Deleted");
                    Con.Close();
                    populate();
                    UpdateonRentDelete();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void RentalDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //IdTb.Text = RentalDGV.SelectedRows[0].Cells[0].Value.ToString();
           // CarRegCb.SelectedValue = RentalDGV.SelectedRows[0].Cells[1].Value.ToString();
           // CustNameTb.Text = RentalDGV.SelectedRows[0].Cells[2].Value.ToString();
           // FeesTb.Text = RentalDGV.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
