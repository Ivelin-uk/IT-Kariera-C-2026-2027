using System.Data;
using System.Xml;

namespace Lectures
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            //BankAccount bankAccount1 = new BankAccount(22,1000);
            //bankAccount1.Deposit(3000);

            //BankAccount bankAccount2 = new BankAccount(2333);

            BankAccount bankAccount3 = new BankAccount();
            bankAccount3.Balance += 1000;
            //bankAccount2.ID = 444;
            //bankAccount2.Balance = 2000;

            Person person1 = new Person();
            person1.Name = "Ivan";
            person1.Age = 10;
          
            //person1.AddBankAccount(bankAccount1);
            //person1.AddBankAccount(bankAccount2);
            person1.AddBankAccount(bankAccount3);

            person1.IntroduceYourself();
            //Console.WriteLine(person1.GetBalance());
    

            // Person person2 = new Person();
            // person2.Name = "Gosho";
            // person2.Age = 4;

            // Person person3 = new Person();
            // person3.Name = "Pesho";
            // person3.Age = 14;

            //person1.IntroduceYourself();
            //person1.PersonInfonBank();


            //person2.IntroduceYourself();
            //person3.IntroduceYourself();
            //System.Console.WriteLine(p1.Name);
            //System.Console.WriteLine(p1.Age);
         
        }
    }
}
