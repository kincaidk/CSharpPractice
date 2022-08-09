using System;

namespace BankAccountChallenge
{
    class CheckingAccount : BankAccount
    {
        private const decimal OVERDRAFT_CHARGE = 35.0m;

        // Constructor
        public CheckingAccount(string firstName, string lastName, decimal initialBalance)
            : base(firstName, lastName, initialBalance) {
            _accountType = "Checking";
        }

        // Methods
        public override void Withdraw(decimal amount) {
            if (amount <= _balance) {
                _balance -= amount;
            } else {
                Console.WriteLine($"CHECKING OVERDRAFT - EXTRA CHARGE OF {OVERDRAFT_CHARGE:C2}.");
                _balance -= (amount + OVERDRAFT_CHARGE);
            }
        }
    }
}