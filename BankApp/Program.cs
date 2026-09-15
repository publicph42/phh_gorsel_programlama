using BankApp;
using System.Net.NetworkInformation;

BankAccount newAccount = new BankAccount();

Console.WriteLine("Hesap sahibinin adini girin!:");
string userInputAccountName = Console.ReadLine();
newAccount.accountName = userInputAccountName;
Console.WriteLine($"\n\n{newAccount.accountName} hesabi olusturuldu!");

static void DisplayMessage()
{
    Console.WriteLine("\n\n1. Bakiye kontrol et!");
    Console.WriteLine("2. Bakiye degistir\n");
}

DisplayMessage();

bool isRunning = true;

while (isRunning)
{
    string userInput = Console.ReadLine();
    switch (userInput)
    {
        case "1":
            newAccount.CheckBalanace();
            DisplayMessage();
            break;
        case "2":
            Console.WriteLine("\nHesaba yatirilcak miktari girinizi:");
            int changeAmount = Convert.ToInt32(Console.ReadLine());
            newAccount.ChangeBalance(changeAmount);
            DisplayMessage();
            break;

    }
}

