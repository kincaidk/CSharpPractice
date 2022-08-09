using System;

namespace BankAccountChallenge
{
    class BankAccount
    {
        // Fields
        private string _accountType; // Checking or Savings
        private decimal _balance;
        private string _accountOwner; // "{firstName} {lastName}"

        // Constructor
        public BankAccount(string firstName, string lastName, decimal initialBalance) {
            _accountOwner = $"{firstName} {lastName}";
            _balance = initialBalance;
        }

        // Methods
        public virtual void Deposit(decimal amount) {
            _balance += amount;
        }

        public virtual void Withdraw(decimal amount) {
            _balance -= amount;
        }
        
        // Properties
        public decimal Balance {
            get => _balance;
        }

        public string AccountOwner {
            get => _accountOwner;
            set => _accountOwner = value;
        }


    }
}