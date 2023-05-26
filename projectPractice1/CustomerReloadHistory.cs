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
using System.Text.RegularExpressions;

namespace projectPractice1
{
    public partial class CustomerReloadHistory : Form
    {
        public CustomerReloadHistory()
        {
            InitializeComponent();
            DisplayReloadHistory();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Project1db;Integrated Security=True");

        private void CustomerReloadHistory_Load(object sender, EventArgs e)
        {
            dgvReloadHistory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DisplayReloadHistory();
        }
        public void DisplayReloadHistory()
        {
            string Quary = "Select * from CustomerReloadHistoryTb where TradePhoneNum = '"+phoneno+"'";
            SqlDataAdapter sda = new SqlDataAdapter(Quary,con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            dgvReloadHistory.Rows.Clear();

            foreach(DataRow item in dt.Rows)
            {
                int n = dgvReloadHistory.Rows.Add();
                dgvReloadHistory.Rows[n].Cells[0].Value = item["PhoneNum"].ToString();
                dgvReloadHistory.Rows[n].Cells[1].Value = item["Reload"].ToString();
                dgvReloadHistory.Rows[n].Cells[2].Value = item["Date"].ToString();
                dgvReloadHistory.Rows[n].Cells[3].Value = "false";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow item in dgvReloadHistory.Rows)
            {
               // bool v = bool.Parse(item.SelectedCells[3].Value.ToString());

                if (bool.Parse(item.Cells[3].Value.ToString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete From CustomerReloadHistoryTb where PhoneNum = '"+item.Cells[0].Value.ToString()+"'",con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            MessageBox.Show("SuccessFully Delete","Infor",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayReloadHistory();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int phonenumber = int.Parse(txtPhoneNum.Text);

            con.Open();
            string quary = "Select * from CustomerReloadHistoryTb where PhoneNum = '" + phonenumber + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(quary,con);
            DataTable DT = new DataTable();
            adapter.Fill(DT);
            dgvReloadHistory.Rows.Clear();

            foreach (DataRow item in DT.Rows)
            {
                int n = dgvReloadHistory.Rows.Add();
                dgvReloadHistory.Rows[n].Cells[0].Value = item["PhoneNum"].ToString();
                dgvReloadHistory.Rows[n].Cells[1].Value = item["Reload"].ToString();
                dgvReloadHistory.Rows[n].Cells[2].Value = item["Date"].ToString();
                dgvReloadHistory.Rows[n].Cells[3].Value = "false";
            }
            con.Close();

            txtPhoneNum.Clear();

        }

        private void txtPhoneNum_TextChanged(object sender, EventArgs e)
        {
            Regex r = new Regex(@"^[0-9]{10}$");
            if (r.IsMatch(txtPhoneNum.Text))
            {
                txtPhoneNum.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                txtPhoneNum.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private int phoneno;

        public int GetTraderPhone
        {
            get { return phoneno; }
            set { phoneno = value; }
        }

        private void dgvReloadHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
