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
    public partial class TraderRegPage : Form
    {
        public TraderRegPage()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Project1db;Integrated Security=True");
                                          
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Regex r = new Regex(@"^[0-9]{10}$");
            if (r.IsMatch(txtPhoNo.Text))
            {
                txtPhoNo.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                txtPhoNo.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
          

            if(txtName.Text == "" || txtAddress.Text == "" || txtNic.Text == "" || txtPhoNo.Text == "" || txtPw.Text == "" || txtConPw.Text == "")
            {
                MessageBox.Show("Missing information, Fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string pw = txtPw.Text;
                    string cpw = txtConPw.Text;

                    if (pw != cpw)
                    {
                        MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPw.Clear();
                        txtConPw.Clear();
                    }
                    else
                    {
                        int phoneno = int.Parse(txtPhoNo.Text);
                        int reload = 0;

                        con.Open();

                        SqlCommand command = new SqlCommand("Insert into TraderRegitorDetailsTb values('" + txtName.Text + "','" + txtAddress.Text + "','" + this.txtDob.Text + "','" + txtNic.Text + "','" + txtPhoNo.Text + "','" + txtPw.Text + "')", con);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Registation Sucessful !!", "Message Box !!");


                        String quary = "Insert into TraderReloadTb(phonenum,Treload) values(@tphoneno,@treload)";
                        SqlCommand cmd = new SqlCommand(quary, con);
                        cmd.Parameters.AddWithValue("@tphoneno", phoneno);
                        cmd.Parameters.AddWithValue("@treload", reload);
                        cmd.ExecuteNonQuery();

                        con.Close();

                        txtName.Clear();
                        txtAddress.Clear();
                        txtNic.Clear();
                        txtPhoNo.Clear();
                        txtPw.Clear();
                        txtConPw.Clear();
                    }
               
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            TraderRegLog traderRegLog = new TraderRegLog();
            traderRegLog.Show();
            this.Hide();
        }

        private void txtNic_TextChanged(object sender, EventArgs e)
        {
           /* Regex r = new Regex(@"^[0-9]{}$");
            if (r.IsMatch(txtNic.Text))
            {
                txtNic.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                txtNic.BackColor = System.Drawing.Color.LightPink;
            }*/
        }

        private void TraderRegPage_Load(object sender, EventArgs e)
        {

        }
    }
}
