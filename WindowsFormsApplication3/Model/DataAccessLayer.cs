using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using MySql.Data.MySqlClient;
 

namespace PirateWars
{
    class DataAccessLayer
    {
        public MySqlConnection connection;

        public DataAccessLayer()
        {
            String user = "root";
            String passw = "";
            String url = "localhost";
            String dbName = "PirateWars";

            String connectionString = @"server=" + url + ";database=" + dbName + ";userid=" + user + ";password=" + passw + ";";

           connection = new MySqlConnection(connectionString);
           
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                Debug.Write("FEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEL!");
            }
 

        }

        public SqlDataReader GetData(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            SqlDataReader dr = null;

            return dr;
            
        }

        public void SendData(string query)
        { 
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }

        public void SaveGameState(List<Port> portList, Player player)
        {   
            string test = player.PlayerName;
            
            string queryPlayer = string.Format("INSERT INTO player VALUES ( '{0}', '{1}', ", player.PlayerName, player.Gold);
            

            foreach (Port port in portList)
            {
                string queryPort = string.Format("INSERT INTO port VALUES ('{0}', '{1}',", port.GetPortName(), player.PlayerName);
                
                foreach (Cargo cargo in port.GetPortsCargoList())
                {
                    queryPort += string.Format(" '{0}',", cargo.Price);   
                }

                queryPort = queryPort.Remove(queryPort.Length - 1);
                queryPort += ")";
                SendData(queryPort);
            }
            

            foreach (Cargo cargo in player.GetPlayersCargoList())
            {
                queryPlayer += "'" + cargo.Amount + "',";
            }
            queryPlayer = queryPlayer.Remove(queryPlayer.Length - 1);
            queryPlayer += ")";

            
           
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

