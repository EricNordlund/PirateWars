using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace PirateWars
{
    class DataAccessLayer
    {
        MySqlConnection connection;
        
     public DataAccessLayer()
        {
            
            string user = "pirate";
            string passw = "PomPom876";
            string url = "alfa.epitet.net";
            string dbName = "PirateWars";

            string connectionString = @"server="+url+";database="+dbName+";userid="+user+";password="+passw+";";

             connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                GetPlayerInfo("noob");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
            Console.Out.WriteLine("Connection opened");
        }

     public MySqlDataReader GetPlayerInfo(string name)
     {
        MySqlCommand cmd;
        cmd = new MySqlCommand("SELECT * FROM player where player.name = '@val1'", connection);
        cmd.Parameters.AddWithValue("@val1", name);
        cmd.Prepare();
        MySqlDataReader res = cmd.ExecuteReader();
        if (!res.HasRows) 
        { 
            Console.WriteLine("Error! "); 
            res.Close();
            return res; 
        }
        else
        {
            //do something
        }
        res.Close();
        return res;
        }
    }
}
