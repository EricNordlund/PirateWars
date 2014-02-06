using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PirateWars
{
    class Port
    {
        private string portName;
        
        Cargo bullet = new Cargo("Bullet");
        Cargo rum = new Cargo("Rum");
        Cargo tobacco = new Cargo("Tobacco");
        Cargo spices = new Cargo("Spices");
        Cargo cloth = new Cargo("Cloth");
        Cargo gunpowder = new Cargo("Gunpowder");
        Cargo pearl = new Cargo("Pearl");

        private List<Cargo> portsCargoList = new List<Cargo>();

        public Port(string port)
        {
            portName = port;
            bullet.Amount = 100;
            rum.Amount = 100;
            tobacco.Amount = 100;
            spices.Amount = 100;
            cloth.Amount = 100;
            gunpowder.Amount = 100;
            pearl.Amount = 100;
            
            bullet.Price = 5;
            rum.Price = 3;
            tobacco.Price = 2;
            spices.Price = 1;
            cloth.Price = 1;
            gunpowder.Price = 2;
            pearl.Price = 5;

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
            cargo.Amount -= 1;
        }

        public Cargo GetCargo(Cargo cargo)
        {
            return cargo;
        }
        
        //Set pris på varje vara



    }
}