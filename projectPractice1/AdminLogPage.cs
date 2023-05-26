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
    public partial class AdminLogPage : Form
    {
        public AdminLogPage()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Project1db;Integrated Security=True");

        private void AdminLogPage_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtRegIndex.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    String regindex;
                    String password;

                    con.Open();
                    String quary1 = "Select * from AdminLoginTb where Regindex = '" + txtRegIndex.Text + "' AND Password = '" + txtPassword.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(quary1, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                      //  regindex = txtRegIndex.Text;
                       // password = txtPassword.Text;

                        AdminOption adminOption = new AdminOption();
                        adminOption.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Login Information ?", "Message Box!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
          
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            SelectType selectType = new SelectType();
            selectType.Show();
            this.Hide();
        }
    }
}
