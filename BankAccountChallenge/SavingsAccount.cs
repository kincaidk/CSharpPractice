using System;

namespace BankAccountChallenge
{
    class SavingsAccount : BankAccount
    {
        // Fields
        private decimal _interest;
        private int _withdrawalCount;
        private const decimal EXCESSIVE_WITHDRAWAL_CHARGE = 2.0m;

        // Constructor
        public SavingsAccount(string firstName, string lastName, decimal interest, decimal initialBalance) 
        : base(firstName, lastName, initialBalance) {
            _accountType = "Savings";
            _interest = interest;
            _withdrawalCount = 0;
        }

        // Methods
        public void ApplyInterest() {
            _balance *= _interest;
        }

        public override void Withdraw(decimal amount) {
            if (amount <= _balance) {
                _balance -= amount;
                if (++_withdrawalCount) {_balance -= EXCESSIVE_WITHDRAWAL_CHARGE;} // $2 charge for withdrawals after the third withdrawal.
            } else {
                Console.WriteLine($"CANNOT WITHDRAWAL {amount} FROM SAVINGS ACCOUNT. CURRENT BALANCE: {_balance}");
            }
        }
    }
}