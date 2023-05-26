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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;

            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel3.Width += 1;

            if(panel3.Width >= 501)
            {
                timer1.Stop();
                SelectType selecttype = new SelectType();
                selecttype.Show();
                this.Hide();
            }
        }
    
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
