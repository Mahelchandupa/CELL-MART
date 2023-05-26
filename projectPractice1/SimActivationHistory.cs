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
    public partial class SimActivationHistory : Form
    {
        public SimActivationHistory()
        {
            InitializeComponent();
            DisplaySimActiveHistory();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Project1db;Integrated Security=True");

        private void SimActivationHistory_Load(object sender, EventArgs e)
        {
            DisplaySimActiveHistory();
        }
        public void DisplaySimActiveHistory()
        {
            string Quary = "Select * from SimActivationTb where TraderTpNo = '" +GetTraderPhone+ "'";
            SqlDataAdapter sda = new SqlDataAdapter(Quary, con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            dgvSimHistory.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dgvSimHistory.Rows.Add();
                dgvSimHistory.Rows[n].Cells[0].Value = item["Name"].ToString();
            //    dgvSimHistory.Rows[n].Cells[1].Value = item["Surname"].ToString();
                dgvSimHistory.Rows[n].Cells[1].Value = item["Nic"].ToString();
            //    dgvSimHistory.Rows[n].Cells[3].Value = item["Dob"].ToString();
            //    dgvSimHistory.Rows[n].Cells[4].Value = item["Gender"].ToString();
                dgvSimHistory.Rows[n].Cells[2].Value = item["Address"].ToString();
                dgvSimHistory.Rows[n].Cells[3].Value = item["PhoneNum"].ToString();
                dgvSimHistory.Rows[n].Cells[4].Value = item["Reload"].ToString();
                dgvSimHistory.Rows[n].Cells[5].Value = item["A_Date"].ToString();
                dgvSimHistory.Rows[n].Cells[6].Value = "false";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvSimHistory.Rows)
            {
                // bool v = bool.Parse(item.SelectedCells[3].Value.ToString());

                if (bool.Parse(item.Cells[6].Value.ToString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete From SimActivationTb where PhoneNum = '" + item.Cells[3].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            MessageBox.Show("SuccessFully Deleted.....!");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplaySimActiveHistory();
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbSetting_Click(object sender, EventArgs e)
        {
            MenuSetting menuSetting = new MenuSetting();
            menuSetting.getPhone = GetTraderPhone;
            menuSetting.Show();
            this.Hide();
        }

        private void dgvSimHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int phoneno;

        public int GetTraderPhone
        {
            get { return phoneno; }
            set { phoneno = value; }
        }
    }
}
