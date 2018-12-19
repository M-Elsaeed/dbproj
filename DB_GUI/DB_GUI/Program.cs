using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DB_GUI
{
    static class Program
    {
        static public MySqlConnection connection;
        static public MySqlCommand cmd;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

            

            string connectionString;
            connectionString = "Server=127.0.0.1;" +
                                "Port=3306;" +
                                "Database=bank;" +
                                "Uid=root;" +
                                "password=J3oss";
            connection = new MySqlConnection(connectionString);

            cmd = connection.CreateCommand();

            try
            {
                connection.Open();
                Console.WriteLine("Connection Succesful");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }}}}