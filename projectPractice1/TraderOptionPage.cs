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
    public partial class TraderOptionPage : Form
    {
        public TraderOptionPage()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Project1db;Integrated Security=True");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        /*    int enteramount = int.Parse(txtReqReload.Text);

            lblReloadAmount.Text = enteramount.ToString();*/
        }

        private void back_Click(object sender, EventArgs e)
        {
            TraderLogPage traderLogPage = new TraderLogPage();
            traderLogPage.Show();
            this.Hide();
        }

        private void TraderOptionPage_Load(object sender, EventArgs e)
        {
            lblPhoneNo.Text = GetPhone.ToString();
            changeAvailableReload();
        }

        private int phoneno;

        public int GetPhone
        {
            get { return phoneno; }
            set { phoneno = value; }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            CustomerReload customerReload = new CustomerReload();
            customerReload.GetTphoneNum = GetPhone;
            customerReload.Show();
            this.Hide();
        }

        int phono;
        public int newreloadeamount; 
        int getAdminreload;

        private void btnReloadReq_Click(object sender, EventArgs e)
        {
            if(txtReqReload.Text == "")
            {
                MessageBox.Show("Filld Empty ?","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                phono = GetPhone;
                int reqreload = int.Parse(txtReqReload.Text);

                SqlCommand cmd1 = new SqlCommand("Select Treload from TraderReloadTb where phonenum = @readphone",con);
                con.Open();
                cmd1.Parameters.AddWithValue("@readphone",phono);
                SqlDataReader read = cmd1.ExecuteReader();

                if (read.Read())
                {
                    newreloadeamount = (int)(read["Treload"]);
                }
                con.Close();



                con.Open();
                string getquary = ("Select Areload from AdminLoginTb");
                SqlCommand cmd5 = new SqlCommand(getquary, con);
                SqlDataReader read1 = cmd5.ExecuteReader();
                if (read1.Read())
                {
                    getAdminreload = (int)(read1["Areload"]);
                }
                con.Close();


                if (getAdminreload >= reqreload)
                {

                    DialogResult dialogResult = MessageBox.Show("Are You Sure ?", "Quection", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {

                        newreloadeamount = newreloadeamount + reqreload;

                        con.Open();
                        string quary2 = ("Update TraderReloadTb  set Treload = @newamount where phonenum = @phonenumber");
                        SqlCommand cmd = new SqlCommand(quary2, con);
                        cmd.Parameters.AddWithValue("@newamount", newreloadeamount);
                        cmd.Parameters.AddWithValue("@phonenumber", phono);
                        cmd.ExecuteNonQuery();


                        int Anewreload = getAdminreload - reqreload;


                        string quary4 = ("Update AdminLoginTb set Areload = @updateAdminreload");
                        SqlCommand cmd3 = new SqlCommand(quary4, con);
                        cmd3.Parameters.AddWithValue("@updateAdminreload", Anewreload);
                        MessageBox.Show("Reload Sucess","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        cmd3.ExecuteNonQuery();

                        con.Close();

                        changeAvailableReload();

                        txtReqReload.Clear();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        txtReqReload.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, Admin Account balance not enough to your request reload","Message Box",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }
        }

        public void changeAvailableReload()
        {
            phono = GetPhone;
            string availablereload;

            con.Open();
            SqlCommand cmd2 = new SqlCommand("Select Treload from TraderReloadTb where phonenum = @phoneoo",con);
            cmd2.Parameters.AddWithValue("@phoneoo",phono);
            SqlDataReader reader = cmd2.ExecuteReader();

            if (reader.Read())
            {
                availablereload = reader["Treload"].ToString();

                lblReloadAmount.Text = availablereload.ToString();

            }

            con.Close();
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            MenuSetting menuSetting = new MenuSetting();
            menuSetting.getPhone = GetPhone;
            menuSetting.Show();
            this.Hide();
        }

        private void btnSimActive_Click(object sender, EventArgs e)
        {
            SimActivationPage simActivationPage = new SimActivationPage();
            simActivationPage.PhoneNum = GetPhone;
            simActivationPage.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
