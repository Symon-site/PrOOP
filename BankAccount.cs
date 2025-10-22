using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PROOP
{
    internal class BankAccount
    {
        private string owner;
        private double balance;
        private bool accountValid;

        public BankAccount(string owner, double balance)
        {
            this.owner = owner;
            if (balance < 0)
            {
                Console.WriteLine("Ошибка, некоректное значение!");
                accountValid = false;
            }
            else 
            {
                this.balance = balance;
                accountValid = true;
            }
        }

        public void Deposit(double money)
        {
            if (!accountValid)
            {
                return;
            }
            else if (money < 0)
            {
                Console.WriteLine("Ошибка, некоректное значение!");
                return;
            }
            balance += money;
            Console.WriteLine($"{owner}, баланс: {balance}");
        }
        public void Withdraw (double money)
        {
            if (!accountValid)
            {
                return;
            }
            else if (money < 0)
            {
                Console.WriteLine("Ошибка, некоректное значение!");
                return;
            }
            else if (money > balance)
            {
                Console.WriteLine("Недостаточно средств");
                return;
            }
            balance -= money;
            Console.WriteLine($"{owner}, баланс: {balance}");
        }
    }
}
