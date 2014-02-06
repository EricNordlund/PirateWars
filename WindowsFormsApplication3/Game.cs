using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PirateWars
{
    class Game
    {
        private Port port;
        private List<Port> portList = new List<Port>();
        private Player player;
        private int turn = 30;

        public void InitializePots()
        {
            Port tartuga = new Port("Tortuga");
            Port blackwater = new Port("Black Water Bay");
            Port providence = new Port("Providence");
            Port shipwreck = new Port("Shipwreck Cove");
            Port freePort = new Port("Free Port");
            Port islaDeMuerta = new Port("Isla de Muerta");
            portList.Add(tartuga);
            portList.Add(blackwater);
            portList.Add(providence);
            portList.Add(shipwreck);
            portList.Add(freePort);
            portList.Add(islaDeMuerta);
        }

        public String EndTurn()
        {
            turn--;
            if (turn == 0)
            {
                GameOver();
            }
            return turn.ToString();
        }

        public void GameOver()
        {
            Console.WriteLine("Game over man, game over! Här ska det väl vara någon slags databas insert med highscore");
        }

        public Player GetPlayer()
        {
            return player;
        }

        public Port GetPort(string portName)
        {
            foreach (Port port in portList)
            {
                if (portName == port.GetPortName())
                {
                    this.port = port;
                }

            }

            return this.port;
        }

        public void SetPlayerName(string pirateName)
        {
            player = new Player(pirateName);
        }

        /// <summary>
        /// Returns the currently selected port.
        /// </summary>
        /// <returns>The current port</returns>
        public Port GetCurrentPort()
        {
            return this.port;
        }

        /// <summary>
        /// Purchases the selected cargo from the current port and adds it to the player's inventory
        /// and updates the gold amount.
        /// </summary>
        /// <param name="cargoName">The name of the cargo to purchase</param>
        public bool PurchaseCargoFromPort(String cargoName)
        {
            Cargo playerCargo = player.GetPlayersCargoList().Find(cargo => cargo.Name == cargoName);
            Cargo portCargo = port.GetPortsCargoList().Find(cargo => cargo.Name == cargoName);

            // check if the player has enough gold
            if (player.GetGoldAmount() >= portCargo.Price)
            {
                playerCargo.IncreaseAmount();
                portCargo.DecreaseAmount();

                player.DecreaseGold(portCargo.Price);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Sells the selected cargo from the player's inventory and adds it to the current port
        /// and updates the gold amount.
        /// </summary>
        /// <param name="cargoName">The name of the cargo to sell</param>
        public bool SellCargoToPort(String cargoName)
        {
            Cargo playerCargo = player.GetPlayersCargoList().Find(cargo => cargo.Name == cargoName);
            Cargo portCargo = port.GetPortsCargoList().Find(cargo => cargo.Name == cargoName);

            // check if the player has this cargo
            if (playerCargo.Amount > 0)
            {
                playerCargo.DecreaseAmount();
                portCargo.IncreaseAmount();

                player.IncreaseGold(portCargo.Price);
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
