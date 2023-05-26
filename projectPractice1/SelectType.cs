using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectPractice1
{
    public partial class SelectType : Form
    {


        public SelectType()
        {
            InitializeComponent();
        }

        private void SelectType_Load(object sender, EventArgs e)
        {
          /*  panel1.BackColor = Color.FromArgb(100, 90, 90, 90);

            pictureBox1.Parent = panel1;
            pictureBox1.BackColor = Color.Transparent;


            lblSAT.Parent = panel1;
            lblSAT.BackColor = Color.Transparent;

            lblHutch.Parent = panel1;
            lblHutch.BackColor = Color.Transparent;*/
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminLogPage adminLogPage = new AdminLogPage();
            adminLogPage.Show();
            this.Hide();
        }

        private void btnTrader_Click(object sender, EventArgs e)
        {
            TraderRegLog traderreglog = new TraderRegLog();
            traderreglog.Show();
            this.Hide();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
