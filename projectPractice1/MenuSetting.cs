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
    public partial class MenuSetting : Form
    {
        public MenuSetting()
        {
            InitializeComponent();
        }

        private int phoneno;

        public int getPhone
        {
            get { return phoneno; }
            set { phoneno = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerReload customerReload = new CustomerReload();
            customerReload.Show();
            this.Hide();
        }

        private void pbHomeBack_Click(object sender, EventArgs e)
        {
            TraderOptionPage traderOptionPage = new TraderOptionPage();
            traderOptionPage.GetPhone = getPhone;
            traderOptionPage.Show();
            this.Hide();
        }

        private void pbCansel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            TraderOptionPage traderOptionPage = new TraderOptionPage();
            traderOptionPage.GetPhone = getPhone;
            traderOptionPage.Show();
            this.Hide();
        }

        private void btnReloadHistory_Click(object sender, EventArgs e)
        {
            CustomerReloadHistory customerReloadHistory = new CustomerReloadHistory();
            customerReloadHistory.GetTraderPhone = getPhone;
            customerReloadHistory.Show();
            this.Hide();
        }

        private void btnSimActHistory_Click(object sender, EventArgs e)
        {
            SimActivationHistory simActivationHistory = new SimActivationHistory();
            simActivationHistory.GetTraderPhone = getPhone;
            simActivationHistory.Show();
            this.Hide();
        }

        private void MenuSetting_Load(object sender, EventArgs e)
        {
        }
    }
}
