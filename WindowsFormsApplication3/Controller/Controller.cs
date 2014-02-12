using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PirateWars
{
    class Controller
    {
        DataAccessLayer dal;
        Game game;
        ExceptionHandler exceptionHandler = new ExceptionHandler();

        public Controller(ref DataAccessLayer dal, ref Game game)
        {
            this.dal = dal;
            this.game = game;
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

        public void SaveGameState()                                                                                                                                                                                               
        {
            dal.SaveGameState(game.PortList, game.Player);
        }

        public void SaveHighScore()
        {
            dal.SaveHighScore(game.Player);
        }

        public Boolean NameCheck(string name)
        {
            SqlDataReader result = dal.NameCheck(name);
            if (result == null)
            {
                return false;
            }
            else
            {
                result.Read();
                game.LoadGameState(LoadGameState(name));
                return true;
            }
        }

        public SqlDataReader LoadGameState(string name)
        {
            return dal.LoadGameState(name);
        }

    }
}
