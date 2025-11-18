using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic15_5
{

        public interface IDepositable
        {
            void Deposit(decimal amount);
        }

        public interface IWithdrawable
        {
            void Withdraw(decimal amount);
        }

        public interface ITransferable
        {
            void Transfer(BankAccount targetAccount, decimal amount);
        }

        public class BankAccount : IDepositable, IWithdrawable, ITransferable
        {
            private decimal balance;

            public BankAccount(decimal initialBalance)
            {
                if (initialBalance < 0)
                    throw new ArgumentException("Начальный баланс не может быть отрицательным.");

                balance = initialBalance;
            }

            public void Deposit(decimal amount)
            {
                if (amount <= 0)
                    throw new ArgumentException("Сумма депозита должна быть больше нуля.");

                balance += amount;
                Console.WriteLine($"Внесено: {amount:C}. Текущий баланс: {balance:C}");
            }

            public void Withdraw(decimal amount)
            {
                if (amount <= 0)
                    throw new ArgumentException("Сумма снятия должна быть больше нуля.");

                if (amount > balance)
                    throw new InvalidOperationException("Недостаточно средств на счету.");

                balance -= amount;
                Console.WriteLine($"Снято: {amount:C}. Текущий баланс: {balance:C}");
            }

            public void Transfer(BankAccount targetAccount, decimal amount)
            {
                Withdraw(amount);
                targetAccount.Deposit(amount);
                Console.WriteLine($"Переведено: {amount:C} на счёт с балансом: {targetAccount.GetBalance():C}");
            }

            public decimal GetBalance()
            {
                return balance;
            }
        }
}

