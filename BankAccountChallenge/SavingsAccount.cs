using System;

namespace BankAccountChallenge
{
    class SavingsAccount : BankAccount
    {
        // Fields
        private decimal _interest;
        private int _withdrawalCount;
        private const decimal EXCESSIVE_WITHDRAWAL_CHARGE = 2.0m;
        private const int EXCESSIVE_WITHDRAWAL_THRESHOLD = 3;

        // Constructor
        public SavingsAccount(string firstName, string lastName, decimal interest, decimal initialBalance) 
        : base(firstName, lastName, initialBalance) {
            _accountType = "Savings";
            _interest = interest;
            _withdrawalCount = 0;
        }

        // Methods
        public void ApplyInterest() {
            _balance += _balance * _interest;
        }

        public override void Withdraw(decimal amount) {
            if (amount <= _balance) {
                base.Withdraw(amount);
                if (++_withdrawalCount > EXCESSIVE_WITHDRAWAL_THRESHOLD) {
                    base.Withdraw(EXCESSIVE_WITHDRAWAL_CHARGE);
                    Console.WriteLine($"MORE THAN {EXCESSIVE_WITHDRAWAL_THRESHOLD} WITHDRAWALS - EXTRA CHARGE OF {EXCESSIVE_WITHDRAWAL_CHARGE:C2}.");
                }
            } else {
                Console.WriteLine($"CANNOT WITHDRAWAL {amount:C2} FROM SAVINGS ACCOUNT. CURRENT BALANCE: {_balance:C2}.");
            }
        }
    }
}