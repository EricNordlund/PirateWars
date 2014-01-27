using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PirateWars
{
    class Port
    {
        public string portName;
        
        public Cargo bullet = new Cargo("Bullet");
        public Cargo rum = new Cargo("Rum");
        public Cargo tobacco = new Cargo("Tobacco");
        public Cargo spices = new Cargo("Spices");
        public Cargo cloth = new Cargo("Cloth");
        public Cargo gunpowder = new Cargo("Gunpowder");
        public Cargo pearl = new Cargo("Pearl");




        public Port(string port)
        {
            portName = port;
        }


        //Set antal av varje vara
        //Set pris på varje vara



    }
}