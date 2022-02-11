using System;
using System.Collections.Generic;

namespace MSDN_practice
{
    public class BankAccount
    {
        private static int accountNumberSeed = 1234567890;
        public string Number { get; }
        public string Owner { get; set; }
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

        
        public BankAccount(string name, decimal initialBalance)
        {
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;//for next account number
            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "initial deposit");
        }

        private List<Transaction> allTransactions = new List<Transaction>();

        public void MakeDeposit(decimal amount, DateTime date,string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount should be +");

            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);


        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "amount should be +");
            }
            if(Balance-amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "wideral should be less than balance");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);

        }

       

    }


}