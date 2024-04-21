using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson1.TypeOfBankAccount;

namespace Lesson1
{
    internal class Person
    {
        public string Name { get; set; }
        public List<BankAccount> BankAccounts { get; set; }
        public Person(string name)
        {
            Name = name;
        }


    }
}
