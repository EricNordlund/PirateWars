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
        
        //Set pris på varje vara



    }
}