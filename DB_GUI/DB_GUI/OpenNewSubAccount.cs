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
    public partial class OpenNewSubAccount : Form
    {
        public OpenNewSubAccount()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Program.serviceFrom.Show();
            this.Close();
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            string query1 = "INSERT INTO `bank`.`accounts_sub_accounts` (`account_id`, `subaccount_id`, `currency_id`, `balance`) VALUES('" + AccountIDTxtBox.Text + "', '" + (AccountTypeComboBox.SelectedIndex + 1) + "', '" + (CurrencyComboBox.SelectedIndex + 1) + "', '200');";
            DBInit.cmd.CommandText = query1;
            DBInit.cmd.ExecuteScalar();

            Program.serviceFrom.Show();
            this.Close();
        }
    }
}
