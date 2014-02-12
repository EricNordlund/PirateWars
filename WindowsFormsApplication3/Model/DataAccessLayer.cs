using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;

namespace PirateWars
{
    class DataAccessLayer
    {
        private SqlConnection connection;

        public DataAccessLayer()
        {
            String connectionString = "user id=name;" +
                                      "password=pw;" +
                                      "server=localhost;" +
                                      "database=PirateWars;";

            this.connection = new SqlConnection(connectionString);
            try
            {
                //connection.Open();
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

        public void saveGameState(List<Port> portList)
        {
            foreach (Port port in portList)
            {
                Trace.WriteLine("Test");
            }
        }

    }
}

