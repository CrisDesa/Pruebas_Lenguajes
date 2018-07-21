using System;

namespace clases
{
    public class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transaction(decimal aumount, DateTime date, string note)
        {
            this.Amount = aumount;
            this.Date = date;
            this.Notes = note;
            
        }
    }
}
