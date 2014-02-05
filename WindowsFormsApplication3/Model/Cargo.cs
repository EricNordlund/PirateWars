
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PirateWars
{
    class Cargo
    {
        public string name { get; set; }
        public int amount { get; set; }
        public int price { get; set; }
        public bool priceDirectionUp { get; set; }

        /**
         * The constructor class
         * @param cargoName The type of the cargo. e.g. sugar
         */
        public Cargo(string cargoName)
        {
            this.name = cargoName;
            this.priceDirectionUp = true;
        }

        /// <summary>
        /// Increases the cargo amount by 1.
        /// </summary>
        public void IncreaseAmount()
        {
            this.amount += 1;
        }

        /// <summary>
        /// Decreases the cargo amount by 1.
        /// </summary>
        public void DecreaseAmount()
        {
            this.amount -= 1;
        }
    }
}