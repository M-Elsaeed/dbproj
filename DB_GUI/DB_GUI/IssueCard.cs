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
    public partial class IssueCard : Form
    {
        public IssueCard()
        {
            InitializeComponent();
            issueDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            expiryDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private void IssueBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int cvv = rnd.Next(100, 999);

            string query = "INSERT INTO `bank`.`customer_cards` (`account_id`, `issuer_id`, `issue_date`, `expirey_date`, `daily_limit`, `card_type`, `CVV`) VALUES ('" + accountIDTxtBox.Text + "', '" + (issuerComboBox.SelectedIndex + 1) + "', '" + issueDateTimePicker.Text + "', '" + expiryDateTimePicker.Text + "', '" + dailyLimitTxtBox.Text + "', '" + (cardTypeComboBox.SelectedIndex + 1) + "', '" + cvv + "');";
            DBInit.cmd.CommandText = query;
            DBInit.cmd.ExecuteScalar();

            Program.serviceFrom.Show();
            this.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Program.serviceFrom.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            expiryDateTimePicker.Value = issueDateTimePicker.Value;
            expiryDateTimePicker.Value = expiryDateTimePicker.Value.AddYears(Convert.ToInt16(cardDurationComboBox.Text));
        }
    }
}
