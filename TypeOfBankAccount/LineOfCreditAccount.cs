using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.TypeOfBankAccount
{
    class LineOfCreditAccount:BankAccount
    {
        public LineOfCreditAccount(string name, decimal initalBalance = 0m, decimal minimumBalance = 50000m, decimal percent = 0.16m) :
           base(name, minimumBalance, initalBalance)
        {
            
            if (percent < 0m || percent > 1m)
                throw new ArgumentOutOfRangeException(nameof(minimumBalance), "Balance must be positive");
            Percent = percent;
        }
        public decimal Percent { get; private set; }
        public decimal Overdrawn { get; private set; } 
        public override void PerformMonthEndTransactions()
        {
            if (Balance < 0)
            {
                // Negate the balance to get a positive interest charge:
                decimal interest = -Balance * Percent;
                MakeWithdraw(interest, DateTime.Now, "Charge monthly interest");
            }
        }
        protected override Transaction? CheckWithdrawalLimit(bool isOverdrawn) =>
    isOverdrawn    ? new Transaction(-Overdrawn, DateTime.Now, "Apply overdraft fee") : default;


    }
}
