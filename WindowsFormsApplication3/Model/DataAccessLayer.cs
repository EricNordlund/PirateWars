using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace PirateWars
{
    class DataAccessLayer
    {
     public DataAccessLayer()
        {
            MySqlConnection connection;
            String user = "pirate";
            String passw = "PomPom876";
            String url = "alfa.epitet.net";
            String dbName = "PirateWars";

            String connectionString = @"server="+url+";database="+dbName+";userid="+user+";password="+passw+";";

             connection = new MySqlConnection(connectionString);



            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.Out.WriteLine("Connection opened");
        }

        






    }
}
