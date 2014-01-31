using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PirateWars
{
    class Port
    {
        string portName;
        
        Cargo bullet = new Cargo("Bullet");
        Cargo rum = new Cargo("Rum");
        Cargo tobacco = new Cargo("Tobacco");
        Cargo spices = new Cargo("Spices");
        Cargo cloth = new Cargo("Cloth");
        Cargo gunpowder = new Cargo("Gunpowder");
        Cargo pearl = new Cargo("Pearl");

        List<Cargo> portsCargoList = new List<Cargo>();

        public Port(string port)
        {
            portName = port;
            bullet.amount = 100;
            rum.amount = 100;
            tobacco.amount = 100;
            spices.amount = 100;
            cloth.amount = 100;
            gunpowder.amount = 100;
            pearl.amount = 100;
            
            bullet.price = 5;
            rum.price = 3;
            tobacco.price = 2;
            spices.price = 1;
            cloth.price = 1;
            gunpowder.price = 2;
            pearl.price = 5;

            portsCargoList.Add(bullet);
            portsCargoList.Add(rum);
            portsCargoList.Add(tobacco);
            portsCargoList.Add(spices);
            portsCargoList.Add(cloth);
            portsCargoList.Add(gunpowder);
            portsCargoList.Add(pearl);
        }

        public List<Cargo> GetPortsCargoList()
        {
            return portsCargoList;
        }

        public string GetPortName()
        {
            return portName;
        }

        public void DecreaseAmount(Cargo cargo)
        {
            cargo.amount -= 1;
        }

        public Cargo GetCargo(Cargo cargo)
        {
            return cargo;
        }
        
        //Set pris på varje vara



    }
}