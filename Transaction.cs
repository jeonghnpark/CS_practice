﻿using System;

namespace MSDN_practice
{
    public class Transaction
    {
        
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Note { get; }

        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Note = note;
        }


    }
}