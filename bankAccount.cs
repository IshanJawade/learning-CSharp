using System;
using System.Collections.Generic;

namespace MyBank{
    class BankAccount{
        public string Number { get; }
        public string Owner { get;  set; }
        public decimal Balance { get; }
        private static double accountNumberSeed = 2021989007000;
        private List<Transactions> allTransactions = new List<Transactions>(); 

        public BankAccount(string name, decimal initialBalance){
            this.Owner = name;
            this.Balance = initialBalance;
            
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposite(decimal amount, DateTime date, string note ){

        }

        public void MakeWithdrawal(decimal amount,  DateTime date, string note){

        }
    }

    class Transactions{
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transactions(decimal amount, DateTime date, string note){
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }

    class MainClass{
        static void Main(String[] args){
            var account = new BankAccount("Ishan", 30000);
            //var account2 = new BankAccount("Advait", 70000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");
        }
    }
}