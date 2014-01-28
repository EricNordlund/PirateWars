using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PirateWars
{
    class Controller
    {
        DataAccessLayer dal;
        Game game;

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
            return game.GetPlayer().gold;
        }

        public List<Cargo> GetCargoList()
        {
            return game.GetPlayer().GetCargoList();
        }


    }
}
