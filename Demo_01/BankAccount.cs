

namespace Lectures
{
    public class BankAccount
    {
        private int id;
        private double balance;

        public BankAccount(int id, double balance)
        {
            this.ID = id;
            this.Balance = balance;
           
        }

        public BankAccount(int id)
        {
            this.ID = id;
            this.Balance = 1000;
        }

        public BankAccount() : this(999999)
        {
           
        }
        
        public int ID 
        {
            get 
            { 
                return id; 
            }
            set 
            { 
                id = value; 
            }
        }
        public double Balance 
        {
            get 
            { 
                return balance; 
            }
            set 
            { 
                if(value > 0)
                {
                    balance = value;    
                }
            }
        }

        public void Deposit(double amount)
        {
            this.balance += amount;
        }
        public void Withdraw(double amount)
        {
            if(this.balance >= amount)
            {
                this.balance -= amount;
            }
        }
        public override string ToString()
        {
            return $"Account {this.id}, balance {this.balance}";
        }
    }
}