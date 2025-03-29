using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Bank
    {
        BankAccount[] accounts;

        public Bank(int count)
        {
            this.accounts = new BankAccount[count];
        }
    }
}
