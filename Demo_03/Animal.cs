using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_03
{
    public class Animal
    {
        private string name;
        private int age;

        public string Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return this.name;
            }
        }

         public int Age
        {
            set
            {
                this.age = value;
            }
            get
            {
                return this.age;
            }
        }
    }
}