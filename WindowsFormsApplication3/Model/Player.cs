using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PirateWars
{
    class Player
    {
        private string playerName;
        private int gold;
       
        private Cargo bullet = new Cargo("Bullet");
        private Cargo rum = new Cargo("Rum");
        private Cargo tobacco = new Cargo("Tobacco");
        private Cargo spices = new Cargo("Spices");
        private Cargo cloth = new Cargo("Cloth");
        private Cargo gunpowder = new Cargo("Gunpowder");
        private Cargo pearl = new Cargo("Pearl");

        private List<Cargo> playersCargoList = new List<Cargo>();

        public Player(string name)
        {
            this.playerName = name;
            this.gold = 100;
            bullet.Amount = 2;
            rum.Amount = 2;
            tobacco.Amount = 2;
            spices.Amount = 0;
            cloth.Amount = 0;
            gunpowder.Amount = 0;
            pearl.Amount = 0;
            playersCargoList.Add(bullet);
            playersCargoList.Add(rum);
            playersCargoList.Add(tobacco);
            playersCargoList.Add(spices);
            playersCargoList.Add(cloth);
            playersCargoList.Add(gunpowder);
            playersCargoList.Add(pearl);

        }

        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        public int Gold
        {
            get { return gold; }
            set { gold = value; }
        }

        public List<Cargo> GetPlayersCargoList()
        {
           return playersCargoList;
        }

        public void DecreaseAmount(Cargo item)
        {
            item.Amount -= 1;
        }

        public void IncreaseAmount(Cargo item)
        {
            item.Amount += 1;
        }
        
        /// <summary>
        /// Increases gold by the specified amount.
        /// </summary>
        /// <param name="amount">The amount to increase</param>
        public void IncreaseGold(int amount)
        {
            this.gold += amount;
        }

        /// <summary>
        /// Decreases gold by the specified amount.
        /// </summary>
        /// <param name="amount">The amount to decrease</param>
        public void DecreaseGold(int amount)
        {
            if (this.gold >= amount)
                this.gold -= amount;
        }
    }
}
