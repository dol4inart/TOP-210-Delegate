using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{

    public class Notificator
    { 
        public void Notify(string owner, string bankAccount, DateTime date, decimal amount, decimal balance)
        {
            Console.WriteLine($"Пользователь: {owner}, счёт: {bankAccount}, дата и время операции {date}, сумма {amount}. Остаток по счёту {balance}");
        }



    }
}
