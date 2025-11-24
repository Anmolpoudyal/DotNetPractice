using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5
{
    internal class BankAccount
    {
        //Create private fields accountNumber and balance.
        
        private string accountNumber;
        private decimal balance;

        /*Create two public properties:
        AccountNumber with only get and not set. (Hint you will pass the value using constructor).*/

        public string AccountNumber
        {
            get { return accountNumber; }
        }

        //Balance with a condition that doesn’t allow negative or 0 values. (Make set private)

        public decimal Balance
        {
            get { return balance; }
            private set
            {
                if (value > 0)
                {
                    balance = value;
                }
                else
                {
                    throw new ArgumentException("Balance must be greater than 0.");
                }
            }
        }

        //Create two methods Deposit(double amount) and withdraw(double amount) these methods will change amount in the balance private field.
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            else
            {
                throw new ArgumentException("Deposit amount must be greater than 0.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                throw new ArgumentException("Withdraw amount must be greater than 0 and less than or equal to the current balance.");
            }
        }







    }
}
