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
           String query=
        }
    }
}
