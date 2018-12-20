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
        Registration registrationForm = new Registration();
        services_page serviceForm = new services_page();

        public Login()
        {
            InitializeComponent();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            registrationForm.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String query = "SELECT user_password FROM bank.empl_accounts WHERE (`userName` = '"+usernameField.Text+"');";
            DBInit.cmd.CommandText = query;

            if (passwordField.Text== Convert.ToString(DBInit.cmd.ExecuteScalar()))
            {
                serviceForm.Show();
            }
        }
    }
}
