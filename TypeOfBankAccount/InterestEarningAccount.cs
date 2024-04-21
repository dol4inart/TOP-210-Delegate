using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.TypeOfBankAccount
{
    class InterestEarningAccount:BankAccount
    {
        public InterestEarningAccount(string name, decimal initalBalance = 0m, decimal minimumBalance = 500m, decimal percent = 0.16m) :
            base(name, initalBalance)
        {
            if (minimumBalance < 0)
                throw new ArgumentOutOfRangeException(nameof(minimumBalance), "Balance must be positive");
            MinimumBalance = minimumBalance;
            if (percent < 0m || percent>1m)
                throw new ArgumentOutOfRangeException(nameof(minimumBalance), "Balance must be positive");
            Percent = percent;
        }
        public decimal MinimumBalance { get; private set; }
        public decimal Percent { get; private set; }

       //BankAccount deposit; 
        public override void PerformMonthEndTransactions()
        {
            if (Balance >= MinimumBalance)
            {
                decimal interest = Balance * Percent;
                MakeDeposit(interest, DateTime.Now, "apply monthly interest");
            }
        }

    }
}
