using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace PirateWars
{
    class DataAccessLayer
    {
        public DataAccessLayer()
        {
            String connectionString = "Data Source=FREDRIK-PC;Initial Catalog=PirateWars;Integrated Security=True";
 
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Connection opened");
                SqlCommand cmd = connection.CreateCommand();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
 
        }
    }
}