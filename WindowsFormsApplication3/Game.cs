using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PirateWars
{
    class Game
    {

        Player player;
        public void InitializePots()
        {
            Port tartuga = new Port("tartuga");
            Port blackwater = new Port("Black Water Bay");
            Port providence = new Port("Providence");
            Port shipwreck = new Port("Shipwreck Cove");
            Port freePort = new Port("Free Port");
            Port islaDeMuerta = new Port("Isla de Muerta");
        }

        public Player GetPlayer()
        {
            return player;
        }



        public void SetPlayerName(string pirateName)
        {
            player = new Player(pirateName);
        }
        
    }
}

