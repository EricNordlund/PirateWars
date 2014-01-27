using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PirateWars
{
    class Player
    {

        Cargo bullet = new Cargo("Bullet");
        Cargo rum = new Cargo("Rum");
        Cargo tobacco = new Cargo("Tobacco");
        Cargo spices = new Cargo("Spices");
        Cargo cloth = new Cargo("Cloth");
        Cargo gunpowder = new Cargo("Gunpowder");
        Cargo pearl = new Cargo("Pearl");

        public string playerName { get; set; }
        public int gold { get; set; }

        public Player(string name)
        {
            this.playerName = name;
            this.gold = 100;
            bullet.amount = 0;
            rum.amount = 0;
            tobacco.amount = 0;
            spices.amount = 0;
            cloth.amount = 0;
            gunpowder.amount = 0;
            pearl.amount = 0;
        }

        public void testRun()
        {
            bullet.amount = 1;
            rum.amount = 1;
            tobacco.amount = 1;
            spices.amount = 1;
            cloth.amount = 1;
            gunpowder.amount = 1;
            pearl.amount = 1;

        }

        public List<Cargo> getCargoList()
        {
            List<Cargo> cargoList = new List<Cargo>();
           

            cargoList.Add(bullet);
            cargoList.Add(rum);
            cargoList.Add(tobacco);
            cargoList.Add(spices);
            cargoList.Add(cloth);
            cargoList.Add(gunpowder);
            cargoList.Add(pearl);
            return cargoList;
        }

    }
}
