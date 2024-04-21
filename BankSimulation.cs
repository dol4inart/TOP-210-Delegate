using Lesson1.TypeOfBankAccount;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class BankSimulation
    {
        public List<Person> Client { get; set; } = null;
        public BankSimulation() 
        {

            Client = GetClient();
            SimulationTransactions();
        }

        public void PerformMonthEndTransactions()
        {
            foreach (var client in Client)
            {
                foreach (var account in client.BankAccounts)
                    account.PerformMonthEndTransactions();
            }
        }
        public string GetClientsAccountsHistory()
        {
            var report = new StringBuilder();
            int k = 0;
            report.AppendLine(" № Client\t\tTypeOfBankAccount");
            foreach (var client in Client)
            {
                report.AppendLine((++k).ToString() + "\t\t" + client.Name);
                int t = 0;
                foreach (var account in client.BankAccounts)
                    report.AppendLine((++t).ToString()+"\t\t" + TypeDescriptor.GetClassName(account).ToString()+"\n" + account.GetAccountHistory()+"\n");
            }
            return report.ToString();




        }
        private List<Person> GetClient()
        {
            return new List<Person>() {
        new Person("Kryukova Yana"){
                        BankAccounts = new List<BankAccount>()
                                       {new InterestEarningAccount("Kryukova Yana",10000m),
                                        new LineOfCreditAccount("Kryukova Yana")}},
        new Person("Ivanov Ivan"){
        BankAccounts = new List<BankAccount>(){ new InterestEarningAccount("Ivanov Ivan",10000m),
                                        new LineOfCreditAccount("Ivanov Ivan"),
                                        new GiftCardAccount("Ivanov Ivan",2000m)}}
            };
        }

        private void SimulationTransactions()
        {
            var person = Client.Find((p) => p.Name == "Kryukova Yana");
            var deposit = person!= null ? person.BankAccounts.Find((p) => p is InterestEarningAccount):null;
            if (deposit != null)
            {
                deposit.MakeDeposit(750, DateTime.Now, "save some money");
                deposit.MakeDeposit(1250, DateTime.Now, "Add more savings");
                deposit.MakeWithdraw(250, DateTime.Now, "Needed to pay monthly bills");
            }
            var lineOfCredit = person != null ? person.BankAccounts.Find((p) => p is LineOfCreditAccount) : null;
            if (lineOfCredit != null)
            {
                lineOfCredit.MakeWithdraw(1000m, DateTime.Now, "Take out monthly advance");
                lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
                lineOfCredit.MakeWithdraw(5000m, DateTime.Now, "Emergency funds for repairs");
                lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
            }
            person = Client.Find((p) => p.Name == "Ivanov Ivan");
            deposit = person != null ? person.BankAccounts.Find((p) => p is InterestEarningAccount) : null;
            if (deposit != null)
            {
                deposit.MakeDeposit(750, DateTime.Now, "save some money");
                deposit.MakeDeposit(1250, DateTime.Now, "Add more savings");
                deposit.MakeWithdraw(250, DateTime.Now, "Needed to pay monthly bills");
            }
            lineOfCredit = person != null ? person.BankAccounts.Find((p) => p is LineOfCreditAccount) : null;
            if (lineOfCredit != null)
            {
                lineOfCredit.MakeWithdraw(1000m, DateTime.Now, "Take out monthly advance");
                lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
                lineOfCredit.MakeWithdraw(5000m, DateTime.Now, "Emergency funds for repairs");
                lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
            }
            var giftCard = person != null ? person.BankAccounts.Find((p) => p is GiftCardAccount) : null;
            if (lineOfCredit != null)
            {
                /*giftCard.MakeWithdraw(20, DateTime.Now, "get expensive coffee");
                giftCard.MakeWithdraw(50, DateTime.Now, "buy groceries");*/
            }


           

        }




    }
}
