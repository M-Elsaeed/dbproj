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
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Program.serviceFrom.Show();
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE `bank`.`person` SET `person_name` = '"+nameField.Text+"', `address` = '"+addressField.Text+"', `phone_number` = '"+phoneField.Text+"', `email` = '"+emailField.Text+"' WHERE (`national_id` = '"+SearchIDTxtBox.Text+"');";
            DBInit.cmd.CommandText = query;
            DBInit.cmd.ExecuteScalar();

            String query1 = "SELECT user_password FROM bank.employees WHERE (`id` = '" + SearchIDTxtBox.Text + "');";
            DBInit.cmd.CommandText = query1;

            if (!oldPassField.Text.Equals(""))
            {
                if (!newPassField.Text.Equals(""))
                {
                    if (oldPassField.Text.Equals(Convert.ToString(DBInit.cmd.ExecuteScalar())))
                    {
                        string query2 = "UPDATE `bank`.`employees` SET `user_password` = '" + newPassField.Text + "' WHERE(`id` = '" + SearchIDTxtBox.Text + "');";
                        DBInit.cmd.CommandText = query2;
                        DBInit.cmd.ExecuteScalar();

                        Program.serviceFrom.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("wrong old pass");
                    }
                }
                else
                {
                    MessageBox.Show("Please entre a new password");
                }
            }
            else
            {
                Program.serviceFrom.Show();
                this.Close();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM bank.person WHERE (`national_id` = '" + SearchIDTxtBox.Text + "');";
            DBInit.cmd.CommandText = query;

            MySqlDataReader reader = DBInit.cmd.ExecuteReader();

            while (reader.Read())
            {
                nameField.Text = reader["person_name"].ToString();
                phoneField.Text = reader["phone_number"].ToString();
                addressField.Text = reader["address"].ToString();
                emailField.Text = reader["email"].ToString();
            }
            reader.Close();
        }
    }
}
