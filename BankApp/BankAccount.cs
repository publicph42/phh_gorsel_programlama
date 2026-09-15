using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class BankAccount
    {
        public string accountName = "placeholder name";
        int balance;

        public void CheckBalanace()
        {
            Console.WriteLine($"Hesap Sahibi: {accountName}");
            Console.WriteLine($"Hesap Bakiyesi: {balance}");
        }

        public void ChangeBalance(int changeAmount)
        {
            
            if (changeAmount > 0)
            {
                balance += changeAmount;
                Console.WriteLine($"{accountName} hesabina {changeAmount} eklendi!");
            }
            else
            {
                balance -= changeAmount;
                Console.WriteLine($"{accountName} hesabindan {changeAmount} cikartildi!");
            }
        }

    }



}
