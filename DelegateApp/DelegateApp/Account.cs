using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp
{
    class Account
    {
        public delegate void AccountStateHandler(string message);
        AccountStateHandler _del;

        public void RegisterHandler(AccountStateHandler del)
        {
            Delegate mainDel = System.Delegate.Combine(del, _del);
            _del = mainDel as AccountStateHandler;
        }
        public void UnregisterHandler(AccountStateHandler del)
        {
            Delegate mainDel = System.Delegate.Remove(del, _del);
            _del = mainDel as AccountStateHandler;
        }

        int _sum;

        public Account(int sum)
        {
            _sum = sum;
        }
        public int CurrentSum
        {
            get { return _sum; }
        }
        public void Put(int sum)
        {
            _sum += sum;
        }
        public void Withdraw(int sum)
        {
            if (sum <= _sum)
            {
                _sum -= sum;
                if (_del != null)
                {
                    _del($"Сумма {sum} снята со счета");
                }
            }
            else
            {
                if (_del != null)
                {
                    _del("Недостаточно денег на счете");

                }
            }
        }

    }
}
