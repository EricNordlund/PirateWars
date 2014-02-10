using System;
using System.Data.SqlClient;

namespace PirateWars
{
    public class Dal
        {
            SqlConnection connection;
        
            public Dal()
            {
                String connectionString = "user id=name;" +
                                          "password=pw;" +
                                          "server=localhost;" +
                                          "database=PirateWars;";

                this.connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }

            public SqlDataReader getData(String query)
            {
                SqlCommand com = new SqlCommand(query, connection);
                SqlDataReader dr = null;
                dr = com.ExecuteReader();

                return dr;

            }

            public void sendData(String query)
            {
                SqlCommand com = new SqlCommand(query, connection);
                com.ExecuteNonQuery();
            }

        }
}

