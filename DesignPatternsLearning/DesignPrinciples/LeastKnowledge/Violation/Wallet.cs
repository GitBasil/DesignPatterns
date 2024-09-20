namespace DesignPatternsLearning.InterfaceSegregation.LeastKnowledge.Violation
{
    public class Wallet
    {
        public Money Money { get; private set; }

        public Wallet(decimal amount)
        {
            Money = new Money(amount);
        }
    }
}