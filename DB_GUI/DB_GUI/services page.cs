using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_GUI
{
    public partial class services_page : Form
    {
        public services_page()
        {
            InitializeComponent();
        }

        private void transferFundsLbl_Click(object sender, EventArgs e)
        {
            Program.transferForm = new Transfer_funds();
            Program.transferForm.Show();
            this.Hide();
        }

        private void settingsLbl_Click(object sender, EventArgs e)
        {
            Program.settingForm = new settings();
            Program.settingForm.Show();
            this.Hide();
        }

        private void ExitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
