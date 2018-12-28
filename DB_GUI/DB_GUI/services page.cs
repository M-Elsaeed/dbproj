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
            switch (Program.RoleID)
            {
                case 1:
                    EmployeeTypeLbl.Text = "Manager";
                    openAccountLbl.Enabled = false;
                    transferFundsLbl.Enabled = false;
                    IssuecardLbl.Enabled = false;
                    withdrawLbl.Enabled = false;
                    depositLbl.Enabled = false;
                    break;
                case 2:
                    EmployeeTypeLbl.Text = "Teller";
                    openAccountLbl.Enabled = false;
                    transferFundsLbl.Enabled = false;
                    IssuecardLbl.Enabled = false;
                    settingsLbl.Enabled = false;
                    break;
                case 3:
                    EmployeeTypeLbl.Text = "Bookkeeper";
                    openAccountLbl.Enabled = false;
                    IssuecardLbl.Enabled = false;
                    withdrawLbl.Enabled = false;
                    depositLbl.Enabled = false;
                    settingsLbl.Enabled = false;
                    break;
                case 4:
                    EmployeeTypeLbl.Text = "Financial Manager";
                    transferFundsLbl.Enabled = false;
                    withdrawLbl.Enabled = false;
                    depositLbl.Enabled = false;
                    settingsLbl.Enabled = false;
                    break;
            }
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

        private void withdrawLbl_Click(object sender, EventArgs e)
        {
            Program.withdrawForm = new Withdraw();
            Program.withdrawForm.Show();
            this.Hide();
        }

        private void openAccountLbl_Click(object sender, EventArgs e)
        {
            Program.openNewAccountForm = new OpenNewSubAccount();
            Program.openNewAccountForm.Show();
            this.Hide();
        }

        private void depositLbl_Click(object sender, EventArgs e)
        {
            Program.depositForm = new Deposit();
            Program.depositForm.Show();
            this.Hide();
        }

        private void IssuecardLbl_Click(object sender, EventArgs e)
        {
            Program.IssueCardForm = new IssueCard();
            Program.IssueCardForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Program.viewTransactions = new ViewTransaction();
            Program.viewTransactions.Show();
            this.Hide();
        }

        private void cityAvg_Click(object sender, EventArgs e)
        {
            Program.cityAvg = new CityAvg();
            Program.cityAvg.Show();
            this.Hide();
        }
    }
}
