using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace PirateWars
{
    class Game
    {
        private Port port;
        private List<Port> portList = new List<Port>();
        private Player player;
        private int turn = 30;
        private SetPrice setPrice = new SetPrice();

        public void InitializePots()
        {
            Port tartuga = new Port("Tortuga", setPrice);
            Port blackwater = new Port("Black Water Bay", setPrice);
            Port providence = new Port("Providence", setPrice);
            Port shipwreck = new Port("Shipwreck Cove", setPrice);
            Port freePort = new Port("Free Port", setPrice);
            Port islaDeMuerta = new Port("Isla de Muerta", setPrice);
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

        public string getPlayerName()
        {
            return player.PlayerName;
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
            if (player.Gold >= portCargo.Price)
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

                player.IncreaseGold(portCargo.Price);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SellCargoToPortAll(String cargoName)
        {
            Cargo playerCargo = player.GetPlayersCargoList().Find(cargo => cargo.Name == cargoName);
            Cargo portCargo = port.GetPortsCargoList().Find(cargo => cargo.Name == cargoName);

            // check if the player has this cargo
            if (playerCargo.Amount > 0)
            {
                while (playerCargo.Amount > 0)
                {
                    playerCargo.DecreaseAmount();

                    player.IncreaseGold(portCargo.Price);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PurchaseCargoFromPortAll(String cargoName)
        {
            Cargo playerCargo = player.GetPlayersCargoList().Find(cargo => cargo.Name == cargoName);
            Cargo portCargo = port.GetPortsCargoList().Find(cargo => cargo.Name == cargoName);

            // check if the player has enough gold
            if (player.Gold >= portCargo.Price)
            {
                while (player.Gold >= portCargo.Price)
                {
                    playerCargo.IncreaseAmount();
                    portCargo.DecreaseAmount();

                    player.DecreaseGold(portCargo.Price);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        /**
         * Updates all of the prices in all of the ports.
         * */
        public void UpdatePrices()
        {
            foreach (Port port in portList)
            {
                List<Cargo> cargoList = port.GetPortsCargoList();
                foreach (Cargo cargo in cargoList)
                {
                    cargo.Price = setPrice.PriceChangeMove(cargo.Price, cargo.PriceDirectionUp);
                }
            }
        }

        public List<Port> PortList
        {
            get { return portList; }
        }

        public Player Player
        {
            get { return player; }
        }

        
        public void LoadGameState(MySqlDataReader result)
        {
            result.Read();
            List<Cargo> clist = player.GetPlayersCargoList();
            int i = 2;
            foreach (Cargo cargo in player.GetPlayersCargoList())
            {
                cargo.Amount = result.GetInt32(i);
                i++;
            }

            foreach (Port port in portList)
            {
                i=11;
                foreach (Cargo cargo in port.GetPortsCargoList())
                {
                    cargo.Price = result.GetInt32(i);
                    i++;
                }
            }
            
            result.Close();
        }

        
    }
}
