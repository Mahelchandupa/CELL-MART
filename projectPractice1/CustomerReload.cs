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
    public partial class CustomerReload : Form
    {
        public CustomerReload()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Project1db;Integrated Security=True");

        private int tphonenumber;

        public int GetTphoneNum
        {
            get { return tphonenumber; }
            set { tphonenumber = value; }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        int tphonee;

        private void CustomerReload_Load(object sender, EventArgs e)
        {
            //  panel2.BackColor = Color.FromArgb(200, 150, 150, 120);

            // panel4.BackColor = Color.FromArgb(200, 150, 150, 120);

            tphonee = GetTphoneNum;
            txtMynum.Text = tphonee.ToString();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int reload = 280;
            txtRamount.Text = reload.ToString(); 
        }

        private void btnAnytime197_Click(object sender, EventArgs e)
        {
            int reload = 197;
            txtRamount.Text = reload.ToString();
        }

        private void btnCliQ1290_Click(object sender, EventArgs e)
        {
            int reload = 1290;
            txtRamount.Text = reload.ToString();
        }

        private void btnAny670_Click(object sender, EventArgs e)
        {
            int reload = 670;
            txtRamount.Text = reload.ToString();
        }

        private void btnHariK368_Click(object sender, EventArgs e)
        {
            int reload = 368;
            txtRamount.Text = reload.ToString();
        }

        private void btnSuper277_Click(object sender, EventArgs e)
        {
            int reload = 277;
            txtRamount.Text = reload.ToString();
        }

        private void btnSuper360_Click(object sender, EventArgs e)
        {
            int reload = 360;
            txtRamount.Text = reload.ToString();
        }

        private void btnSuper96_Click(object sender, EventArgs e)
        {
            int reload = 96;
            txtRamount.Text = reload.ToString();
        }

        int traderreload;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool value = false;

            if(txtCusNum.Text == "" || txtRamount.Text == "")
            {
                MessageBox.Show("Missing Info");
            }
            else
            {
                tphonee = GetTphoneNum;
                int customerphoneno = int.Parse(txtCusNum.Text);
                int customerreload = int.Parse(txtRamount.Text);

                con.Open();
                SqlCommand cmd2 = new SqlCommand("Select Treload from TraderReloadTb where phonenum = @tphone",con);
                cmd2.Parameters.AddWithValue("@tphone",tphonee);
                SqlDataReader reader = cmd2.ExecuteReader();

                if (reader.Read())
                {
                    traderreload = (int)reader["Treload"];
                }
                con.Close();

                if(customerreload > traderreload)
                {
                    MessageBox.Show("There is no money in the Account !");
                }
                else
                {
                    traderreload = traderreload - customerreload;

                    con.Open();
                    SqlCommand cmd4 = new SqlCommand("Insert into CustomerReloadHistoryTb values(@cunum,@cureload,'"+this.dateTimePicker1.Text+"',@traderp)",con);
                    cmd4.Parameters.AddWithValue("@cunum",customerphoneno);
                    cmd4.Parameters.AddWithValue("@cureload",customerreload);
                    cmd4.Parameters.AddWithValue("@traderp",tphonee);
                    cmd4.ExecuteNonQuery();
                    con.Close();


                    MessageBox.Show("Reload Successfully going","Infor",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    value = true;
                    con.Close();
                }
            }

            if (value)
            {
                con.Open();
                SqlCommand cmd5 = new SqlCommand("Update TraderReloadTb set Treload = @tradernewreload where phonenum = @traderphonenum",con);
                cmd5.Parameters.AddWithValue("@traderphonenum",tphonee);
                cmd5.Parameters.AddWithValue("@tradernewreload",traderreload);
                cmd5.ExecuteNonQuery();
                con.Close();
            }
            txtCusNum.Clear();
            txtRamount.Clear();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            TraderOptionPage traderOptionPage = new TraderOptionPage();
            traderOptionPage.GetPhone = GetTphoneNum;
            traderOptionPage.Show();
            this.Hide();
        }

        private void pbCansel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtCusNum_TextChanged(object sender, EventArgs e)
        {

            Regex r = new Regex(@"^[0-9]{10}$");
            if (r.IsMatch(txtCusNum.Text))
            {
                txtCusNum.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                txtCusNum.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbSetting_Click(object sender, EventArgs e)
        {
            MenuSetting menuSetting = new MenuSetting();
            menuSetting.getPhone = GetTphoneNum;
            menuSetting.Show();
            this.Hide();
        }
    }
}
