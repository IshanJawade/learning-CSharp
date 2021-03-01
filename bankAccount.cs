using System;
using System.Collections.Generic;

namespace MyBank{
    class BankAccount{
        public string Number { get; }
        public string Owner { get;  set; }
        public decimal Balance { 
            get{
                decimal balance = 0;
                foreach(var item in allTransactions){
                    balance += item.Amount;
                }
                return balance;
            }
        }
        private static double accountNumberSeed = 2021989007000;
        private List<Transaction> allTransactions = new List<Transaction>(); //Make this private after use 

        public BankAccount(string name, decimal initialBalance){
            this.Owner = name;

            MakeDeposite(initialBalance, DateTime.Now, "Initial Balance");

            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposite(decimal amount, DateTime date, string note ){
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount,  DateTime date, string note){
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        public string GetAccountHostory(){
            
        }
    }

    class Transaction{
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transaction(decimal amount, DateTime date, string note){
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }

    class MainClass{
        static void Main(String[] args){
            var account = new BankAccount("Ishan", 30000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            Console.WriteLine($"Account Balance is: {account.Balance}");

            account.MakeWithdrawal(15000, DateTime.Now, "Medical Emergency");
            account.MakeWithdrawal(1000, DateTime.Now, "Internet Recharge");
            account.MakeWithdrawal(500, DateTime.Now, "Starbucks Coffee");
            Console.WriteLine("");

            /*
            Console.WriteLine("All Transaction Record: ");
            foreach(var i in account.allTransactions){
                Console.Write($"{i.Amount}  ");
                Console.Write($"{i.Date}  ");
                Console.Write($"{i.Notes}");
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine($"Account Balance is: {account.Balance}");
            */

            // Test that the initial balances must be positive.
            // Test for a negative balance.
            try
            {
                account.MakeWithdrawal(-750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }

        }
    }
}