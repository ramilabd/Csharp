using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class Bank<T> where T : Account
    {
        T[] accounts;
        public string Name { get; private set; }

        public Bank(string name)
        {
            this.Name = name;
        }

        // метод создания счета
        public void Open(AccountType accountType, decimal sum, AccountStateHandler addSumHandler, AccountStateHandler withdrawSumHandler,
            AccountStateHandler calculationHandler, AccountStateHandler closeAccountHandler, AccountStateHandler openAccountHandler)
        {
            T newAccount = null;

            switch (accountType)
            {
                case AccountType.Ordinary:
                    newAccount = new DemandAccount(sum, 1) as T;
                    break;
                case AccountType.Deposit:
                    newAccount = new DepositAccount(sum, 40) as T;
                    break;
            }
        }





            // тип счета
            public enum AccountType
        {
            Ordinary,
            Deposit
        }

        }

    }
}
