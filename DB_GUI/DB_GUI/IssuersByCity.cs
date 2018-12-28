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
    public partial class IssuersByCity : Form
    {
        public IssuersByCity()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            DBInit.cmd.CommandText = "";
            string city = cityField.Text,issuer = issuerComboBox.Text;

            DBInit.cmd.CommandText = "select national_id,person_name from person where national_id in (select id from customers where account_id in (select account_id from customer_cards where issuer_id in (select id from issuers where issuername like \"" +
                issuer +
                "\"" +
                "))) and city like \"" +
                city +
                "\"";


            if (!(issuer == ""))
            {
                //DBInit.cmd.CommandText = "select * from person";
                MySqlDataReader reader = DBInit.cmd.ExecuteReader();
                string myStr = "";
                while (reader.Read())
                {
                    //national_id, person_name, from_account, to_account, amount
                    myStr += "National ID : " + reader["national_id"].ToString();
                    myStr += " | Person Name : " + reader["person_name"].ToString();
                    myStr += "\n";

                }
                MessageBox.Show(myStr);
                reader.Close();
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
