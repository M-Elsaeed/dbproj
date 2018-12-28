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
    public partial class ViewTransaction : Form
    {
        public ViewTransaction()
        {
            InitializeComponent();
            panel1.Hide();
        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            panel1.Show();
            DBInit.cmd.CommandText = "";
            string frBranch = fromBranchField.Text;
            string sort = sortDrop.Text;
            string sortDir = sortDirDrop.Text;
            int minAmount = minAmountField.Text == "" ? 0 : Int32.Parse(minAmountField.Text);
            int maxAmount = maxAmountField.Text == "" ? Int32.MaxValue : Int32.Parse(maxAmountField.Text);

            DBInit.cmd.CommandText = "SELECT national_id, person_name, from_account, to_account, amount FROM person INNER JOIN customers ON person.national_id = customers.id INNER JOIN(SELECT * FROM transactions AS Tfrom WHERE Tfrom.id IN (SELECT transaction_id FROM branch_transaction WHERE branch_transaction.transaction_id IN ( SELECT SWIFT FROM branches " +
                "WHERE b_name LIKE \"" +
                frBranch +
                "\") ) )" +
                "as T " +
                "where amount >=" +
                minAmount +
                " and " +
                "amount<=" +
                maxAmount
                ;
            if (sort != "")
            {
                if (sort == "Customer Name")
                    DBInit.cmd.CommandText += " order by person.person_name ";
                else
                    DBInit.cmd.CommandText += " order by amount ";
                if (sortDir != "")
                {
                    DBInit.cmd.CommandText += sortDir + ";";
                }
                else
                {
                    DBInit.cmd.CommandText += ";";
                }

            }
            else
            {
                DBInit.cmd.CommandText += ";";
            }

            if (!(frBranch == ""))
            {
                MySqlDataReader reader = DBInit.cmd.ExecuteReader();
                while (reader.Read())
                {
                    //national_id, person_name, from_account, to_account, amount
                    resultsText.Text += "National ID : " + reader["national_id"].ToString();
                    resultsText.Text += " | Person Name : " + reader["person_name"].ToString();
                    resultsText.Text += " | From Account : " + reader["from_account"].ToString();
                    resultsText.Text += " | To Account : " + reader["to_account"].ToString();
                    resultsText.Text += " | Amount : " + reader["amount"].ToString();
                    resultsText.Text += "\n";

                }
                reader.Close();
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

        private void viewTransactions_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            resultsText.Text = "";
        }
    }
}
