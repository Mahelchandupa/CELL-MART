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
    public partial class TradersDetails : Form
    {
        public TradersDetails()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Project1db;Integrated Security=True");

        private void TradersDetails_Load(object sender, EventArgs e)
        {
            DisplayTradersData();
        }

        public void DisplayTradersData()
        {
            string Quary = "Select * from TraderRegitorDetailsTb";
            SqlDataAdapter sda = new SqlDataAdapter(Quary, con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            dgvTradersData.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dgvTradersData.Rows.Add();
                dgvTradersData.Rows[n].Cells[0].Value = item["Name"].ToString();
                dgvTradersData.Rows[n].Cells[1].Value = item["Address"].ToString();
                dgvTradersData.Rows[n].Cells[2].Value = item["Dob"].ToString();
                dgvTradersData.Rows[n].Cells[3].Value = item["Nic"].ToString();
                dgvTradersData.Rows[n].Cells[4].Value = item["PhoneNo"].ToString();
             /* dgvTradersData.Rows[n].Cells[5].Value = item["Password"].ToString();
                dgvTradersData.Rows[n].Cells[6].Value = "false";*/
            }
        }

        private void dgvTradersData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            AdminOption adminOption = new AdminOption();
            adminOption.Show();
            this.Hide();
        }
    }
}
