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
                System.Windows.Forms.MessageBox.Show("Connection to database timed out, game will not be able to save or load gamestates");
            }
 

        }

        public MySqlDataReader GetData(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dr = cmd.ExecuteReader();

            return dr;
            
        }

        public void SendData(string query)
        { 
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }

        public void SaveGameState(List<Port> portList, Player player, Game game)
        {

            string deleteQuery = string.Format("DELETE FROM player WHERE playerName = '{0}'; DELETE FROM port WHERE playerName = '{0}'", player.PlayerName);
            SendData(deleteQuery);
            
            string queryPlayer = string.Format("INSERT INTO player VALUES ( '{0}', '{1}', '{2}',", player.PlayerName, player.Gold, game.Turn);
            

            foreach (Port port in portList)
            {
                string queryPort = string.Format("INSERT INTO port VALUES ('{0}', '{1}',", player.PlayerName, port.GetPortName());
                
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

       

        
        public bool NameCheck(string name)
        {
            string query = string.Format("SELECT playerName FROM player WHERE playerName = '{0}'", name);
            Debug.WriteLine(query);
            MySqlDataReader dr = GetData(query);

            if (dr.HasRows)
            {
                dr.Dispose();
                return true;
            }
            else
            {
                dr.Dispose();
                return false;
            }

            
        }

        public MySqlDataReader LoadGameState(string name)
        {
            string query = string.Format("SELECT * FROM player pl JOIN port po ON pl.playerName = po.playerName AND pl.playerName = '{0}' ORDER BY portName", name);
            Debug.WriteLine(query);
            return (GetData(query));
        }

        public void AddToHighscoreList(Player player)
        {
            string deleteQuery = string.Format("DELETE FROM player WHERE playerName = '{0}';", player.PlayerName);
            SendData(deleteQuery);

            string queryPlayer = string.Format("INSERT INTO highscore VALUES ( '{0}', '{1}' )", player.PlayerName, player.Gold);
            SendData(queryPlayer);

        }

    }
}

