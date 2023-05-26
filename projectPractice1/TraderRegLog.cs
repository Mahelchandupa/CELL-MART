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
    public partial class TraderRegLog : Form
    {
        public TraderRegLog()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            TraderRegPage traderRegPage = new TraderRegPage();
            traderRegPage.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            TraderLogPage traderLogPage = new TraderLogPage();
            traderLogPage.Show();
            this.Hide();
        }

        private void TraderRegLog_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;

            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;

            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;


            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
        }

        private void Cancelicon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            SelectType selectType = new SelectType();
            selectType.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
