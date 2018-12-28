using MySql.Data.MySqlClient;
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
    public partial class viewTransactions : Form
    {
        public viewTransactions()
        {
            InitializeComponent();
        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            string frBranch = fromBranchField.Text;
            string toBranch = toBranchField.Text;
            string sort = sortDrop.Text;
            string sortDir = sortDirDrop.Text;
            int minAmount = minAmountField.Text == "" ? 0 : Int32.Parse(minAmountField.Text);
            int maxAmount = maxAmountField.Text == "" ? Int32.MaxValue : Int32.Parse(maxAmountField.Text);
            DBInit.cmd.CommandText = "select national_id,person_name,from_account,to_account,amount" +
                                     "from person inner join customer on person.national_id = customer.id" +
                                     "inner join (" +
                                     "            select * " +
                                     "            from transaction as Tfrom" +
                                     "            where Tfrom.id in" +
                                     "                  (" +
                                     "                  select transaction_id" +
                                     "                  from branch_transactions" +
                                     "                  where branch_transactions in" +
                                     "                        (" +
                                     "                        select SWIFT" +
                                     "                        from branches " +
                                     "                        where b_name like ' " + fromBranchField + "'" +
                                     "                        )" +
                                     "            )" +
                                     "on Tfrom.from_accountid = customer.id"
                                    ;
            if (!(frBranch == "" && toBranch == ""))
            {

                MySqlDataReader reader = DBInit.cmd.ExecuteReader();
                MessageBox.Show("Query successful");

            }
            else
            {
                MessageBox.Show("Please fill form fields");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Program.serviceFrom.Show();
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void sortDirDrop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
