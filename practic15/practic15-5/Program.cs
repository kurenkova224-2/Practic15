using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic15_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount(1000);
            BankAccount account2 = new BankAccount(500);

            Console.WriteLine($"Начальный баланс счёта 1: {account1.GetBalance():C}");
            Console.WriteLine($"Начальный баланс счёта 2: {account2.GetBalance():C}");

            account1.Transfer(account2, 200);

            Console.WriteLine($"\nБаланс счёта 1 после перевода: {account1.GetBalance():C}");
            Console.WriteLine($"Баланс счёта 2 после перевода: {account2.GetBalance():C}");
        }
    }
}
