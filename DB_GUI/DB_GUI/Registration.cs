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
            birthdaytimepicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            string birthdate = birthdaytimepicker.Text;

            string query = "INSERT INTO `bank`.`person` (`national_id`, `person_name`, `birth_date`, `address`, `city`, `phone_number`, `email`) VALUES('"+nidtxtbox.Text+"', '"+nametxtbox.Text+"', '"+ birthdate + "', '"+addtxtbox.Text+"', '"+citytxtbox.Text+"', '"+phoneNotxtbox.Text+"', '"+emailtxtbox.Text+"');";

            DBInit.cmd.CommandText = query;

            DBInit.cmd.ExecuteReader();
        }
    }
}
