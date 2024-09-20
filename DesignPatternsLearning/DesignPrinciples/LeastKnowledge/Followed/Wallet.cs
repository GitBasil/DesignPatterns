namespace DesignPatternsLearning.InterfaceSegregation.LeastKnowledge
{
    public class Wallet
    {
        public Money Money { get; private set; }

        public Wallet(decimal amount)
        {
            Money = new Money(amount);
        }

        public bool CanAfford(decimal price)
        {
            return Money.HasEnoughAmount(price);
        }
    }
}