﻿using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DB_GUI
{
    public partial class Registration : Form
    {
        bool wrong=true;

        public Registration()
        {
            InitializeComponent();
            birthdaytimepicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            customePnl.Hide();
            employeePnl.Hide();
            registerbtn.Enabled = false;
            accountIDTxtbox.Enabled = false;
        }

        private void customerRario_CheckedChanged(object sender, EventArgs e)
        {
            customePnl.Show();
            employeePnl.Hide();
            registerbtn.Enabled = true;
        }

        private void employeeRadio_CheckedChanged(object sender, EventArgs e)
        {
            employeePnl.Show();
            customePnl.Hide();
            registerbtn.Enabled = true;
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            string birthdate = birthdaytimepicker.Text;

            try
            {
                string query1 = "INSERT INTO `bank`.`person` (`national_id`, `person_name`, `birth_date`, `address`, `city`, `phone_number`, `email`) VALUES('" + nidtxtbox.Text + "', '" + nametxtbox.Text + "', '" + birthdate + "', '" + addtxtbox.Text + "', '" + citytxtbox.Text + "', '" + phoneNotxtbox.Text + "', '" + emailtxtbox.Text + "');";
                DBInit.cmd.CommandText = query1;
                DBInit.cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                MessageBox.Show("Registration Failed , Please re-entrer National ID as an account is already existing with this ID");
                wrong = false;
            }
            
            if (employeeRadio.Checked && wrong == true)
            {
                try
                {
                    string query2 = "INSERT INTO `bank`.`employees` (`id`, `salary`, `role_id`,`username`, `user_password`) VALUES ('" + nidtxtbox.Text + "', '" + salarytxtbox.Text + "', '" + (RoleIDComboBox.SelectedIndex + 1) + "','" + userNameTxtBox.Text + "', '" + passwordTxtBox.Text + "');";
                    DBInit.cmd.CommandText = query2;
                    DBInit.cmd.ExecuteScalar();
                    MessageBox.Show("Registration Successful");
                    Program.loginForm.Show();
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Registration Failed , Username is used");
                    string query5 = "DELETE FROM `bank`.`person` WHERE (`national_id` = '" + nidtxtbox.Text + "');";
                    DBInit.cmd.CommandText = query5;
                    DBInit.cmd.ExecuteScalar();
                }
            }

            else if (customerRario.Checked && wrong == true)
            {
                string query3 = "INSERT INTO `bank`.`customers` (`id`) VALUES ('"+nidtxtbox.Text+"');";
                DBInit.cmd.CommandText = query3;
                DBInit.cmd.ExecuteScalar();

                string query4 = "SELECT account_id FROM bank.customers WHERE id = " + nidtxtbox.Text + ";";
                DBInit.cmd.CommandText = query4;
                accountIDTxtbox.Text= Convert.ToString(DBInit.cmd.ExecuteScalar());

                MessageBox.Show("Registration Successful");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Program.loginForm.Show();
            this.Close();
        }
    }
}
