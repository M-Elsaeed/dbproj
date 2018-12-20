using MySql.Data.MySqlClient;
using System;


namespace DB_GUI
{
    static class db_init
    {
        public static MySqlCommand cmd;
        static MySqlConnection connection;
        static string connectionString;

        static db_init()
        {
            connectionString = "Server=127.0.0.1;" +
                                "Port=3306;" +
                                "Database=bank;" +
                                "Uid=root;" +
                                "password=J3oss";
            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                Console.WriteLine("sxjicbhiudsabdf");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            cmd = connection.CreateCommand();
        }
    }
}
