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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Program.serviceFrom.Show();
            this.Close();
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE `bank`.`accounts_sub_accounts` SET `balance` = balance +'"+AmountTxtBox.Text+"' WHERE(`account_id` = '" + AccountIDTxtBox.Text+ "') and(`subaccount_id` = '" + (AccountTypeComboBox.SelectedIndex + 1) + "') and(`currency_id` = '" + (CurrencyComboBox.SelectedIndex + 1) + "');";
            DBInit.cmd.CommandText = query;
            DBInit.cmd.ExecuteScalar();

            Program.serviceFrom.Show();
            this.Close();
        }
    }
}
