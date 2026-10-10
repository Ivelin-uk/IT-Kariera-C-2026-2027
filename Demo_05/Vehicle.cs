using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_05
{
    public class Vehicle
    {
        private int hp; 

        private string brand; 

        public Vehicle(string brand, int hp)
        {
            this.brand = brand;
            this.hp = hp;
        }

        public int Hp
        {
            set
            {
                this.hp = value;
            }
            get
            {
                return this.hp;
            }
        }

        public string Brand
        {     
            get
            {
                return this.brand;
            }
        }
    }
}