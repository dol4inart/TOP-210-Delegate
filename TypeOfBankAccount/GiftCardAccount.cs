using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.TypeOfBankAccount
{
    class GiftCardAccount : BankAccount
    {
        public GiftCardAccount(string name, decimal initalBalance = 0m) :
    base(name, initalBalance)
        { }

        public override void PerformMonthEndTransactions()
        {
            MakeWithdraw(Balance, DateTime.Now, "Excuse us!");
        }
    }

}
