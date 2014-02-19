
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PirateWars
{
    class Cargo
    {

        private string name;
        private int price;
        private int amount;
        private bool priceDirectionUp;


        
        /**
         * The constructor class
         * @param cargoName The type of the cargo. e.g. sugar
         */
        public Cargo(string cargoName)
        {
            this.name = cargoName;
            this.priceDirectionUp = true;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public bool PriceDirectionUp
        {
            get { return priceDirectionUp; }
            set { priceDirectionUp = value; }
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