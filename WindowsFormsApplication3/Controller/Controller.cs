using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace PirateWars
{
    class Controller
    {
        DataAccessLayer dal;
        Game game;
        Player player;
        Form1 view;
        /// <summary>
        /// Constructor that references DAL and Game 
        /// via inparameters.
        /// </summary>
        public Controller(ref DataAccessLayer dal, ref Game game)
        {
            this.dal = dal;
            this.game = game;
        }

        public void SetView(Form1 view)
        {
            this.view = view;
        }
       
        /// <summary>
        /// Method to get Game.
        /// </summary>
        public Game GetGame()
        {
            return game;
        }

        /// <summary>
        /// Method to set players name.
        /// </summary>
        public void SetPlayerName(string pirateName)
        {
            game.SetPlayerName(pirateName);
        }
        
        /// <summary>
        /// Method to get players gold. (Either starting
        /// value or from a saved game.)
        /// </summary>
        public int GetPlayerStartingGold()
        {
            return game.Player.Gold;
        }

        /// <summary>
        /// Get players cargo from a list.
        /// </summary>
        public List<Cargo> GetPlayersCargoList()
        {
            return game.Player.GetPlayersCargoList();
        }

        /// <summary>
        /// Get ports cargo from a list.
        /// </summary>
        public List<Cargo> GetPortsCargoList(string portName)
        {
            return game.GetPort(portName).GetPortsCargoList();
        }
       
        /// <summary>
        /// updates prices
        /// </summary>
        public void UpdatePrices()
        {
            game.UpdatePrices();
        }

        public void GameOver()
        {
            view.GameOver();
        }

        /// <summary>
        /// Saves the game.
        /// </summary>
        public void SaveGameState()                                                                                                                                                                                               
        {
            dal.SaveGameState(game.PortList, game.Player, game);
        }

       
        /// <summary>
        /// Loads a previous game.
        /// </summary>
        public void LoadGameState()
        {
            MySqlDataReader dr = dal.LoadGameState(game.getPlayerName());
            game.LoadGameState(dr);
            view.UpdateView();
            
        }

        public void AddToHighscore()
        {
            dal.AddToHighscore(game.Player);
        }

        public MySqlDataReader GetData(string query)
        {
            return dal.GetData(query);
        }
    }
}
