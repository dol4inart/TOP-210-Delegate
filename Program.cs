using System;
using System.Collections.Generic;
using Lesson1.TypeOfBankAccount;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {


            #region BankAccount
            //BankAccount bankAccount = new BankAccount("Yana", 1000);
            //InterestEarningAccount interestEarningAccount = 
            //    new InterestEarningAccount();
            //bankAccount.Owner = "Yana Kryokova";

            //Console.WriteLine($"Owner { bankAccount.Owner }\n{ bankAccount.Balance }");
            //bankAccount.MakeWithdraw(200, DateTime.Now, "Rent peyment");
            //Console.WriteLine(bankAccount.Balance);
            //bankAccount.MakeDeposit(100, DateTime.Now, "Friend pay me back");
            //Console.WriteLine(bankAccount.Balance);
            //// Test that the initial balance must be positive
            //BankAccount invalidBankAccount;
            //try
            //{
            //    invalidBankAccount = new BankAccount("Invalid Bank Account", -100000);

            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    // Console.WriteLine("Exceptoin caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    bankAccount.MakeWithdraw(1000, DateTime.Now, "______");
            //}
            //catch (InvalidOperationException e)
            //{
            //    // Console.WriteLine("Exception caught trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //}
            //Console.WriteLine(bankAccount.GetAccountHistory());
            #endregion
            var BigBank = new BankSimulation();
            Console.WriteLine(BigBank.GetClientsAccountsHistory());
            BigBank.PerformMonthEndTransactions();
            Console.WriteLine(BigBank.GetClientsAccountsHistory());

        }
    }
}
