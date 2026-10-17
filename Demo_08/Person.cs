using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Lectures
{
    public class Person
    {
        private string name = string.Empty; 
        private int age;

        public string Name
        { 
            get 
            { 
                return name; 
            }
            set 
            { 
                if(value.Length >= 3)
                {
                    this.name = value; 
                }
            }
        }

        public int Age
        { 
            get 
            { 
                return age; 
            }
            set 
            { 
                if(value < 1)
                {
                    throw new AgeException("Invalid age");
                }
                else
                {
                    this.age = value;
                }
            }
        }
    }
}
