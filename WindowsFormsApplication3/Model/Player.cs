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

        List<Cargo> cargoList = new List<Cargo>();

        public string playerName { get; set; }
        public int gold { get; set; }

        public Player(string name)
        {
            this.playerName = name;
            this.gold = 100;
            bullet.amount = 2;
            rum.amount = 2;
            tobacco.amount = 2;
            spices.amount = 0;
            cloth.amount = 0;
            gunpowder.amount = 0;
            pearl.amount = 0;
            cargoList.Add(bullet);
            cargoList.Add(rum);
            cargoList.Add(tobacco);
            cargoList.Add(spices);
            cargoList.Add(cloth);
            cargoList.Add(gunpowder);
            cargoList.Add(pearl);

        }

        public List<Cargo> GetCargoList()
        {
           return cargoList;
        }

        public void DecreaseAmount(Cargo item)
        {
            item.amount -= 1;
        }

    }
}
