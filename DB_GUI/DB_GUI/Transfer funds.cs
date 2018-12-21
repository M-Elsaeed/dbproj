using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_GUI;
using MySql.Data.MySqlClient;

namespace DB_GUI
{
    public partial class Transfer_funds : Form
    {
        public Transfer_funds()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            if (!(fromAccountField.Text == "" || fromSubaccountField.Text == "" || toAccountField.Text == "" || toSubaccountField.Text == "" || amountField.Text == ""))
            {
                int frAcc = Int32.Parse(fromAccountField.Text);
                int frSubAcc = Int32.Parse(fromSubaccountField.Text);
                int toAcc = Int32.Parse(toAccountField.Text);
                int toSubAcc = Int32.Parse(toSubaccountField.Text);
                int amount = Int32.Parse(amountField.Text);
                DBInit.cmd.CommandText =
                    "insert into transactions(`from_account`, `from_subAccount`, `to_account`, `to_subAccount`, `amount`, `t_time`)"
                    +
                    "VALUES(" + "'" + frAcc + "','" + frSubAcc + "','" + toAcc + "','" + toSubAcc + "','" + amount + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                MySqlDataReader reader = DBInit.cmd.ExecuteReader();
                MessageBox.Show("Transaction was successful");
                Program.serviceFrom.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill form fields");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Program.serviceFrom.Show();
            this.Close();
        }
    }
}
