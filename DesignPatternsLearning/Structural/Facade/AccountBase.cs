using System;

namespace DesignPatternsLearning.Structural.Facade
{
    public abstract class AccountBase : IAccount
    {
        protected int accountNumber;
        protected decimal balance;

        public AccountBase(decimal initAmount)
        {
            this.balance = initAmount;
            this.accountNumber = new Random().Next(1000, 9999); // Random account number
            Console.WriteLine($"Created new account {this.accountNumber} with initial balance: {this.balance}");
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount}. New balance for account {accountNumber}: {balance}");
        }

        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew {amount}. New balance for account {accountNumber}: {balance}");
            }
            else
            {
                Console.WriteLine($"Insufficient funds to withdraw {amount} from account {accountNumber}. Current balance: {balance}");
            }
        }

        public void Transfer(decimal amount)
        {
            Console.WriteLine($"Transferred {amount} from account {accountNumber}.");
        }

        public int GetAccountNumber()
        {
            return accountNumber;
        }
    }
}
