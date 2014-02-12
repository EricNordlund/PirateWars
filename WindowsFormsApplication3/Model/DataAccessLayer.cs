using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;

namespace PirateWars
{
    class DataAccessLayer
    {
        public SqlConnection connection;

        public DataAccessLayer()
        {
            string connectionString = "user id=name;" +
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

        public SqlDataReader GetData(string query)
        {
            SqlCommand com = new SqlCommand(query, connection);
            SqlDataReader dr = null;
            dr = com.ExecuteReader();

            return dr;

        }

        public void SendData(string query)
        { 
            SqlCommand com = new SqlCommand(query, connection);
            com.ExecuteNonQuery();
        }

        public void SaveGameState(List<Port> portList, Player player)
        {
            string queryPort = "INSERT INTO port VALUES (";
            string queryPlayer = "INSERT INTO player VALUES (";

            foreach (Port port in portList)
            {
                queryPort = queryPort + "'" + port.GetPortName() + "',";
            }

            foreach (Cargo cargo in player.GetPlayersCargoList())
            {
                queryPlayer = queryPlayer + "'" + cargo.Amount + "',";
            }
            SendData(queryPort);
            SendData(queryPlayer); 
        }

        public void SaveHighScore(Player player)
        {
            string query = "INSERT INTO highscore (pName, pGold) VALUES ('" + player.PlayerName + "', '" + player.Gold + "')";
            SendData(query);
        }

        public SqlDataReader NameCheck(string name)
        {
            string query = "SELECT pName FROM name WHERE pName = '" + name + "'";
            return GetData(query);
        }

        public SqlDataReader LoadGameState(string name)
        {
            string query = "SELECT * FROM player WHERE = pName = '" + name + "' UNION SELECT * FROM port WHERE pName = '" + name + "'";
            return GetData(query);
        }

    }
}

