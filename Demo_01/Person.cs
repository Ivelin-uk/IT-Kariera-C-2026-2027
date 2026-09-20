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
        private List<BankAccount> accounts = new List<BankAccount>();

        public String Name
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
                if(value > 1)
                {
                    this.age = value;
                }
            }
        }

        public void AddBankAccount(BankAccount bankAccount)
        {
            this.accounts.Add(bankAccount);
        }

        public double GetBalance()
        {
            double sum = 0;
            for(int i = 0; i < this.accounts.Count; i++)
            {
                BankAccount currentBankAccount = accounts[i];
                sum += currentBankAccount.Balance;
            }
            return sum;
        }

        // public BankAccount BankAccount
        // { 
        //     get 
        //     { 
        //         return bankAccount; 
        //     }
        //     set 
        //     { 
                
        //         this.bankAccount = value;
        //     }
        // }

        // public void PersonInfonBank()
        // {
        //      Console.WriteLine("ID: {0} BALANCE: {1}", this.bankAccount.ID, this.bankAccount.Balance);
        // }

        public void IntroduceYourself() 
        {
            Console.WriteLine("Здравейте! Аз съм {0} и съм на {1} години.", name, age);
            Console.WriteLine("My balance: {0}", this.GetBalance());
        }
    }
}
