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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            loginBtn.Enabled = false;
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            Program.registrationForm = new Registration();
            Program.registrationForm.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String query = "SELECT user_password FROM bank.employees WHERE (`userName` = '" + usernameField.Text+"');";
            DBInit.cmd.CommandText = query;

            if (passwordField.Text.Equals(Convert.ToString(DBInit.cmd.ExecuteScalar())))
            {
                String query1 = "SELECT role_id FROM bank.employees WHERE (`userName` = '" + usernameField.Text + "');";
                DBInit.cmd.CommandText = query1;
                Program.RoleID = Convert.ToInt16(DBInit.cmd.ExecuteScalar());

                Program.serviceFrom = new services_page();
                Program.serviceFrom.Show();
                this.Hide();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {
            loginBtn.Enabled = true;
            if (passwordField.Text == "")
            {
                loginBtn.Enabled = false;
            }
        }
    }
}
