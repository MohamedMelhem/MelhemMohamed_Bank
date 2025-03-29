using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class SavingsAccount : BankAccount
    {
        static double baseInterest = 10.5;

        public double Interset {  get; set; }
        public SavingsAccount(Owner owner) : base(owner)
        {
            Interset = baseInterest;

        }

        public override bool Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                return true;   
            }
            return false;
        }
        public void AddInterest()
        {
            Balance += Interset/100 * Balance;
        }
    }
}
