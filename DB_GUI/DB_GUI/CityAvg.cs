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
    public partial class CityAvg : Form
    {
        public CityAvg()
        {
            InitializeComponent();
        }

        private void computeBtn_Click(object sender, EventArgs e)
        {

            string city = cityText.Text;
            DBInit.cmd.CommandText = "select avg(balance) as Average from accounts_sub_accounts where account_id in (select account_id from customers where id in (select national_id from person where city like \"" + city + "\"));";

            if (!(city == ""))
            {

                MySqlDataReader reader = DBInit.cmd.ExecuteReader();
                reader.Close();
                avgText.Text = Convert.ToString(DBInit.cmd.ExecuteScalar());
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
