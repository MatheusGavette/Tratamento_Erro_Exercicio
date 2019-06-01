using System;
using Exercicio01.Entities.Exception;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account()
        {

        }

        public Account (int number, string holder, double balance, double withDrawLimit)
        {
            if (balance < 0 || withDrawLimit < 0)
            {
                throw new DomainException("The balance e with draw limit must be great than zero");
            }

            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            if (amount < 1)
            {
                throw new DomainException("Deposit need to a be great zero");
            }

            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (amount > WithDrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }

            Balance -= amount;
        }
    }
}
