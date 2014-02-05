using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PirateWars
{
    class Port
    {
        string portName;
        
        Cargo bullet = new Cargo("Bullets");
        Cargo rum = new Cargo("Rum");
        Cargo tobacco = new Cargo("Tobacco");
        Cargo spices = new Cargo("Spices");
        Cargo cloth = new Cargo("Cloth");
        Cargo gunpowder = new Cargo("Gunpowder");
        Cargo pearl = new Cargo("Pearls");

        List<Cargo> portsCargoList = new List<Cargo>();

        public Port(string port, SetPrice setPrice)
        {
            portName = port;

            portsCargoList.Add(bullet);
            portsCargoList.Add(rum);
            portsCargoList.Add(tobacco);
            portsCargoList.Add(spices);
            portsCargoList.Add(cloth);
            portsCargoList.Add(gunpowder);
            portsCargoList.Add(pearl);

            foreach (Cargo cargo in portsCargoList)
            {
                cargo.price = setPrice.initialPrice(cargo.name);
            }
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