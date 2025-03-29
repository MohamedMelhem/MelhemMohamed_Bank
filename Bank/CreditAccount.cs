using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class CreditAccount : BankAccount
    {
        double creditLimit;
        public CreditAccount(double creditLimit,Owner owner) : base(owner)
        {
            this.creditLimit = creditLimit;
        }

        public double CreditLimit { get => creditLimit;}

        public override bool Withdraw(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
