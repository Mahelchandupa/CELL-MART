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
    public partial class TraderLogPage : Form
    {
        public TraderLogPage()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Project1db;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtPhoneNo.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Missing Information","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int pno = int.Parse(txtPhoneNo.Text);
                    string password = txtPassword.Text;

                    con.Open();
                    String quary1 = "Select * from TraderRegitorDetailsTb where PhoneNo = '" + txtPhoneNo.Text + "' AND Password = '" + txtPassword.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(quary1, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        pno = int.Parse(txtPhoneNo.Text);
                        password = txtPassword.Text;

                        TraderOptionPage traderOptionPage = new TraderOptionPage();
                        traderOptionPage.GetPhone = pno;
                        traderOptionPage.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalide Login Information ?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            TraderRegLog traderRegLog = new TraderRegLog();
            traderRegLog.Show();
            this.Hide();
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

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void TraderLogPage_Load(object sender, EventArgs e)
        {

        }
    }
}
