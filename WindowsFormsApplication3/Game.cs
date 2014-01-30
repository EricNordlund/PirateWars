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
        
    }
}

