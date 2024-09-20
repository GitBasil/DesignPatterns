namespace DesignPatternsLearning.InterfaceSegregation.LeastKnowledge
{
    public class Money
    {
        public decimal Amount { get; private set; }

        public Money(decimal amount)
        {
            Amount = amount;
        }

        public bool HasEnoughAmount(decimal price)
        {
            return Amount >= price;
        }
    }
}