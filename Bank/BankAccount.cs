using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal abstract class BankAccount : BankingService
    {
        double balance;
        public BankAccount(Owner owner) : base(owner)
        {
        }

        public double Balance { get => balance; protected set => balance = value; }

        public void Desposit(double amount)
        {
            balance += amount;
        
        }

        public abstract bool Withdraw(double amount);
        public BankCard NewCard(string cardNumber)
        {
            return new BankCard(cardNumber, balance, Owner);
        }


    }
}
