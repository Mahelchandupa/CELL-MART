using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace projectPractice1
{
    public partial class SimActivationPage : Form
    {
        public SimActivationPage()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Project1db;Integrated Security=True");


        private int phonenumber;

        public int PhoneNum
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }

        int t_phonenum;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_MouseEnter(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.Red;
            btnSubmit.ForeColor = Color.White;
        }

        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.Lime;
            btnSubmit.ForeColor = Color.Black;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Regex r = new Regex (@"^[0-9]{10}$");
            if (r.IsMatch(txtPhoneNo.Text))
            {
                txtPhoneNo.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                txtPhoneNo.BackColor = System.Drawing.Color.LightPink;
            }
        }

        string gender;
        int traderreload;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool check = false;

            if(txtName.Text == "" || txtSurname.Text == "" || txtNic.Text == "" || txtAddress.Text == "" || txtPhoneNo.Text == "" || txtReload.Text == "")
            {
                MessageBox.Show("Missing information, Fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string name = txtName.Text;
                    string surname = txtSurname.Text;
                    int nic = Convert.ToInt32(txtNic.Text); ;
                    string address = txtAddress.Text;
                    int phonenum = int.Parse(txtPhoneNo.Text);
                    int reload = int.Parse(txtReload.Text);
                    t_phonenum = PhoneNum;

                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("Select Treload from TraderReloadTb where phonenum = @tphone", con);
                    cmd2.Parameters.AddWithValue("@tphone", t_phonenum);
                    SqlDataReader reader = cmd2.ExecuteReader();

                    if (reader.Read())
                    {
                        traderreload = (int)reader["Treload"];
                    }
                    con.Close();

                    if(reload > traderreload)
                    {
                        MessageBox.Show("Insufficient balance !");
                    }
                    else
                    {
                        traderreload = traderreload - reload;

                        con.Open();

                        SqlCommand command = new SqlCommand("Insert into SimActivationTb values('" + name + "','" + surname + "','" + nic + "','" + this.dtpDob.Text + "','" + gender + "','" + address + "','" + phonenum + "','" + reload + "','" + this.dateTimePicker2.Text + "', '"+ PhoneNum +"')", con);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Sim Sucessfully Activated","Infor",MessageBoxButtons.OK,MessageBoxIcon.Information);

                        // customer data inserting into history database
                        SqlCommand cmd4 = new SqlCommand("Insert into CustomerReloadHistoryTb values(@cunum,@cureload,'" + this.dateTimePicker2.Text + "', @traderPhoneNum)", con);
                        cmd4.Parameters.AddWithValue("@cunum",phonenum);
                        cmd4.Parameters.AddWithValue("@cureload", reload);
                        cmd4.Parameters.AddWithValue("@traderPhoneNum", PhoneNum);
                        cmd4.ExecuteNonQuery();


                        check = true;
                        con.Close();
                    }

                    if (check)
                    { // minus and update trader db
                        con.Open();
                        SqlCommand cmd5 = new SqlCommand("Update TraderReloadTb set Treload = @tradernewreload where phonenum = @traderphonenum", con);
                        cmd5.Parameters.AddWithValue("@traderphonenum", t_phonenum);
                        cmd5.Parameters.AddWithValue("@tradernewreload", traderreload);
                        cmd5.ExecuteNonQuery();
                        con.Close();
                    }

                    txtName.Clear();
                    txtSurname.Clear();
                    txtNic.Clear();
                    txtAddress.Clear();
                    txtPhoneNo.Clear();
                    txtReload.Clear();
                    rbFemale.Checked = false;
                    rbMale.Checked = false;

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message); // showin errors
                }
            }
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            TraderOptionPage traderOptionPage = new TraderOptionPage();
            traderOptionPage.GetPhone = PhoneNum;
            traderOptionPage.Show();
            this.Hide();
        }

        private void pbSetting_Click(object sender, EventArgs e) // history button
        {
            MenuSetting menuSetting = new MenuSetting();
            menuSetting.getPhone = PhoneNum;
            menuSetting.Show();
            this.Hide();
        }

        private void SimActivationPage_Load(object sender, EventArgs e)
        {

        }


    }
}
