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
            DBInit.cmd.CommandText = "SELECT * FROM bank.atms;";

            MySqlDataReader reader = DBInit.cmd.ExecuteReader();

            while (reader.Read())
            {
                MessageBox.Show(reader["id"].ToString());
                MessageBox.Show(reader["addreSS"].ToString());
            }
        }
    }
}
