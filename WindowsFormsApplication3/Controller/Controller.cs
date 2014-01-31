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
            return game.GetPlayer().gold;
        }

        public List<Cargo> GetPlayersCargoList()
        {
            return game.GetPlayer().GetPlayersCargoList();
        }

        public List<Cargo> GetPortsCargoList(string portName)
        {
            return game.GetPort(portName).GetPortsCargoList();
        }

        public void DecreaseAmountPlayer(Cargo cargo)
        {
            if(game.GetPlayer().GetCargo(cargo).amount>0)
            {
                game.GetPlayer().DecreaseAmount(cargo);
            }
            else
            {
                exceptionHandler.HandleException("DecreaseAmountPlayer");
            }
        }

        public void DecreaseAmountPort(Cargo cargo, Port port)
        {
            if(port.GetCargo(cargo).amount>0)
            {
                port.DecreaseAmount(cargo);
            }
            else
            {
                exceptionHandler.HandleException(cargo + "is currently out of stock");
            }
        }
    }
}
