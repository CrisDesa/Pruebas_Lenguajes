using System;
using System.Collections.Generic;


namespace clases
{
    public class BanckAccount
    {
        public string Number {get;}
        public string Owner {get; set;}
        public decimal Balance 
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            } 
        }
        private static int accountNumberSeed = 123456;
        private List<Transaction> allTransactions = new List<Transaction>();

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);

        }

        public BanckAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");

            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++; 
        }
        
    }
}