using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PirateWars
{
    class Player
    {
        public string playerName { get; set; }
        public int gold { get; set; }

        public Player(string name)
        {
            this.playerName = name;
            this.gold = 100;
        }



        public Cargo bullet = new Cargo("Bullet");
        public Cargo rum = new Cargo("Rum");
        public Cargo tobacco = new Cargo("Tobacco");
        public Cargo spices = new Cargo("Spices");
        public Cargo cloth = new Cargo("Cloth");
        public Cargo gunpowder = new Cargo("Gunpowder");
        public Cargo pearl = new Cargo("Pearl");

        public void getCargoList()
        {
        }

    }
}