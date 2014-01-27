
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

        /**
         * The constructor class
         * @param cargoName The type of the cargo. e.g. sugar
         */
        public Cargo(string cargoName)
        {
            this.name = cargoName;
        }
    }
}
