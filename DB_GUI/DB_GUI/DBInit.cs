﻿using MySql.Data.MySqlClient;
using System;


namespace DB_GUI
{
    static class DBInit
    {
        public static MySqlCommand cmd;
        static MySqlConnection connection;
        static string connectionString;

        static DBInit()
        {
            connectionString = "Server=localhost;" +
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
