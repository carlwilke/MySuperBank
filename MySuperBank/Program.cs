using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Gunter Bratwurst", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");
            account.MakeWithdrawal(20, DateTime.Now, "Coffee Mug");
            account.MakeWithdrawal(25, DateTime.Now, "Instant Coffee");
            account.MakeWithdrawal(20, DateTime.Now, "Sugar");
            Console.WriteLine(account.GetAccountHistory());
        }
    }
}