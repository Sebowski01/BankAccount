using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
   class Account
    {
        private double balance;

       public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public double Withdraw(double amount)
        {
            if (balance > 0 && balance > amount) {
                balance -= amount;
                Console.WriteLine($"Remaining balance is {balance}");
                return balance;
            } else
            {
                Console.WriteLine("Balance is too low");
                return balance;
            }
           
            
        }

        public double Deposite(double amount)
        {
            
            balance += amount;
            return balance;
        }


        public void DisplayMessege()
        {
            Console.WriteLine("Your Balance {0}", Balance);
        }
       
        public Account(double balance)
        {
            Balance = balance;
        }


        
    }
}
