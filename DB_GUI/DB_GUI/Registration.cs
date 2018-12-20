using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DB_GUI
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            db_init.cmd.CommandText = "SELECT * FROM bank.atms;";

            MySqlDataReader reader = db_init.cmd.ExecuteReader();

            while (reader.Read())
            {
                MessageBox.Show(reader["id"].ToString());
                MessageBox.Show(reader["addreSS"].ToString());
            }
        }
    }
}
