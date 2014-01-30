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

        List<Cargo> playersCargoList = new List<Cargo>();

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
            playersCargoList.Add(bullet);
            playersCargoList.Add(rum);
            playersCargoList.Add(tobacco);
            playersCargoList.Add(spices);
            playersCargoList.Add(cloth);
            playersCargoList.Add(gunpowder);
            playersCargoList.Add(pearl);

        }

        public List<Cargo> GetPlayersCargoList()
        {
           return playersCargoList;
        }

        public void DecreaseAmount(Cargo item)
        {
            item.amount -= 1;
        }

        public void IncreaseAMount(Cargo item)
        {
            item.amount += 1;
        }
            
      
    }
}
