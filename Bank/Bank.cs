using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Bank
    {
        List<BankAccount> accounts;

        public Bank(int maxAccountCount)
        {
            this.accounts = new List<BankAccount>(maxAccountCount);
        }

        public BankAccount NewAccount(Owner owner, double creditlimit)
        {
            BankAccount account;
            if (creditlimit > 0)
            {
                account = new CreditAccount(creditlimit, owner);
            }
            else
            {
                account = new SavingsAccount(owner);
            }
         
            accounts.Add(account);
            return account;
        }

        public double TotalBalance(Owner owner) 
        { 
            double total = 0;

            foreach (BankAccount account in accounts) 
            {
                if (owner == account.Owner)
                {
                    total += account.Balance;
                }

            }
            return total;
            
        
        }
        public BankAccount MaximalBalanceAccount(Owner owner) {
            int index = 0;
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].Owner == owner)
                {
                    if (accounts[i].Balance >= accounts[index].Balance)
                    {
                        index = i;
                        
                    }
                }
            }
            return accounts [index];
        }
        public double TotalCreditLimit()
        {
            double totalCredit = 0;
            foreach (CreditAccount account in accounts)
            {
                totalCredit += account.CreditLimit;

            }
            return totalCredit;
        }

    }
}
