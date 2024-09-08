namespace DesignPatternsLearning.Structural.Facade
{
    public interface IAccount
    {
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        void Transfer(decimal amount);
        int GetAccountNumber();
    }
}