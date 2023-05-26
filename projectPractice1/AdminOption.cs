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

namespace projectPractice1
{
    public partial class AdminOption : Form
    {
        public AdminOption()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Project1db;Integrated Security=True");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            AdminLogPage adminLogPage = new AdminLogPage();
            adminLogPage.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTradersData_Click(object sender, EventArgs e)
        {
            TradersDetails tradersDetails = new TradersDetails();
            tradersDetails.Show();
            this.Hide();
        }

        private void AdminOption_Load(object sender, EventArgs e)
        {
            Balance();
        }

        public void Balance()
        {
            string availableBalance;

            con.Open();
            SqlCommand cmd2 = new SqlCommand("Select Areload from AdminLoginTb ", con);
            SqlDataReader reader = cmd2.ExecuteReader();

            if (reader.Read())
            {
                availableBalance = reader["Areload"].ToString();

                lblBalance.Text = availableBalance.ToString();

            }

            con.Close();
        }
    }
}
