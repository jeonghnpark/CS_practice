using System;

namespace MSDN_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"parameter count: {args.Length}");

            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"{i}th argument :  {args[i]}");
            }
            var name = "Park";
            var item = (Name: "Jeong", Price: 1.99, perPage: 3);
            var date = DateTime.Now;
            Console.WriteLine($"Hello,{name}. It's a pleasure to meet you ");
            Console.WriteLine($"On {date:d} price of {item.Name} was {item.Price:C2}");

            var account = new BankAccount("Park", 1000);
            Console.WriteLine($"Name: {account.Owner} Balance: {account.Balance}");
            account.MakeDeposit(100, DateTime.Now, "add 100");
            Console.WriteLine($"Name: {account.Owner} Balance: {account.Balance}");
            account.MakeWithdrawal(300, DateTime.Now, "minus 300"); 
            Console.WriteLine($"Name: {account.Owner} Balance: {account.Balance}");

            BankAccount invalidAccount;

            try
            {
                invalidAccount = new BankAccount("invalid", -500);
            }catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("exception caught for negative amount ");
                Console.WriteLine(e.ToString());

            }

        }
    }

    
}
