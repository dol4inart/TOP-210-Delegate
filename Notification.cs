using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{

    public class NotificationService
    {
        private Action<string, string, DateTime, decimal, decimal> notificationDelegate;

        public void Register(Action<string, string, DateTime, decimal, decimal> handler) => notificationDelegate += handler;

        public void Unregister(Action<string, string, DateTime, decimal, decimal> handler) => notificationDelegate -= handler;

        public void Notify(string owner, string bankAccount, DateTime date, decimal amount, decimal balance)
        {
            notificationDelegate?.Invoke(owner, bankAccount, date, amount, balance);
        }



    }
}
