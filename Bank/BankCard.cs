using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class BankCard : BankingService
    {

        double accountBalance;
        string cardNumber;
        public BankCard(string cardNumber,double accountBalance,Owner owner) : base(owner)
        {
            this.cardNumber = cardNumber;
            this.accountBalance = accountBalance;
        }

        public string CardNumber { get => cardNumber; }
        public bool Purchase(double amount)
        {
            if (accountBalance - amount >= 0)
            {
                accountBalance -= amount;
                return true;
                
            }
            return false;

        }

    }
}
