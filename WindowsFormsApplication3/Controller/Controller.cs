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
        ExceptionHandler exceptionHandler = new ExceptionHandler();

        public Controller(ref DataAccessLayer dal, ref Game game)
        {
            this.dal = dal;
            this.game = game;
        }

        public void SetView(Form1 view)
        {
            this.view = view;
        }

        public Game GetGame()
        {
            return game;
        }

        public void SetPlayerName(string pirateName)
        {
            game.SetPlayerName(pirateName);
        }

        public int GetPlayerStartingGold()
        {
            return game.Player.Gold;
        }

        public List<Cargo> GetPlayersCargoList()
        {
            return game.Player.GetPlayersCargoList();
        }

        public List<Cargo> GetPortsCargoList(string portName)
        {
            return game.GetPort(portName).GetPortsCargoList();
        }

        public void UpdatePrices()
        {
            game.UpdatePrices();
        }

        public void GameOver()
        {
            view.GameOver();
        }


        public void SaveGameState()                                                                                                                                                                                               
        {
            dal.SaveGameState(game.PortList, game.Player, game);
        }

        public void SaveHighScore()
        {
            dal.SaveHighScore(game.Player);
        }

        public void NameCheck(string name)
        {
           
            if (!dal.NameCheck(name))
            {
                Debug.WriteLine("Namecheck returned null");
            }
            else
            {
                //LoadGameState();

                Debug.WriteLine("Namecheck returned results");

            }
            
        }

        public void LoadGameState()
        {
            MySqlDataReader dr = dal.LoadGameState(game.getPlayerName());
            game.LoadGameState(dr);
            view.UpdateView();
            
        }

    }
}
