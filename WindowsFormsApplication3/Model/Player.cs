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

        public List<Cargo> GetPlayersCargoList()
        {
           return playersCargoList;
        }

        public void DecreaseAmount(Cargo item)
        {
            item.Amount -= 1;
        }

        public void IncreaseAMount(Cargo item)
        {
            item.Amount += 1;
        }
        
        /// <summary>
        /// Returns the total gold amount of the player.
        /// </summary>
        /// <returns>The gold amount</returns>
        public int GetGoldAmount()
        {
            return gold;
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
