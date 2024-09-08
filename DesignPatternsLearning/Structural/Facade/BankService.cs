namespace DesignPatternsLearning.Structural.Facade
{
    public class BankService
    {
        private Dictionary<int, IAccount> bankAccounts = new Dictionary<int, IAccount>();

        public int CreateNewAccount(string type, decimal initAmount)
        {
            IAccount newAccount;
            switch (type.ToLower())
            {
                case "chequing":
                    newAccount = new Chequing(initAmount);
                    break;
                case "saving":
                    newAccount = new Saving(initAmount);
                    break;
                case "investment":
                    newAccount = new Investment(initAmount);
                    break;
                default:
                    Console.WriteLine("Invalid account type");
                    return -1;
            }

            if (newAccount != null)
            {
                int accountNumber = newAccount.GetAccountNumber();
                bankAccounts.Add(accountNumber, newAccount);
                return accountNumber;
            }

            return -1;
        }

        public void TransferMoney(int toAccountNumber, int fromAccountNumber, decimal amount)
        {
            if (bankAccounts.ContainsKey(toAccountNumber) && bankAccounts.ContainsKey(fromAccountNumber))
            {
                IAccount fromAccount = bankAccounts[fromAccountNumber];
                IAccount toAccount = bankAccounts[toAccountNumber];

                fromAccount.Transfer(amount);
                toAccount.Deposit(amount);
                Console.WriteLine($"Transferred {amount} from account {fromAccountNumber} to account {toAccountNumber}");
            }
            else
            {
                Console.WriteLine("One or both account numbers are invalid");
            }
        }
    }
}
