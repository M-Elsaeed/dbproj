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

            string query = "INSERT INTO `bank`.`person` (`national_id`, `person_name`, `birth_date`, `address`, `city`, `phone_number`, `email`) VALUES('" + nidtxtbox.Text + "', '" + nametxtbox.Text + "', '" + birthdate + "', '" + addtxtbox.Text + "', '" + citytxtbox.Text + "', '" + phoneNotxtbox.Text + "', '" + emailtxtbox.Text + "');";

            DBInit.cmd.CommandText = query;

            DBInit.cmd.ExecuteScalar();

            if (true)
            {

            }
        }
        

    }
}
