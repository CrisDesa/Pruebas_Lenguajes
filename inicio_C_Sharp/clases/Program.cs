using System;


namespace clases
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BanckAccount("Cris", 1000);
            Console.WriteLine($"Account {account.Number} was create for {account.Owner} {account.Balance} initial balance");
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "friend paid me back");
            Console.WriteLine(account.Balance);

            try
            {
                var invalidAccount = new BanckAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught");
                //Console.WriteLine(e.ToString());
            }

            // Test para saldp negativo
            try
            {
                account.MakeWithdrawal(750, DateTime.Now, "Attemmpt to overdraw");
                
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caugtht trying to overdraw");
                //Console.WriteLine(e.ToString());
            }
        }
    }
}
