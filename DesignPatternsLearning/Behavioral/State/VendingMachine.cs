namespace DesignPatternsLearning.Behavioral.State
{
    public class VendingMachine
    {
        private IState idleState;
        private IState hasOneDollarState;
        private IState outOfStockState;
        private IState currentState;
        private int count;

        public VendingMachine(int count)
        {
            idleState = new IdleState();
            hasOneDollarState = new HasOneDollarState();
            outOfStockState = new OutOfStockState();

            this.count = count;

            if (count > 0)
            {
                currentState = idleState;
            }
            else
            {
                currentState = outOfStockState;
            }
        }

        public void InsertDollar()
        {
            currentState.InsertDollar(this);
        }

        public void EjectMoney()
        {
            currentState.EjectMoney(this);
        }

        public void Dispense()
        {
            currentState.Dispense(this);
        }

        public void SetState(IState state)
        {
            currentState = state;
        }

        public IState GetIdleState()
        {
            return idleState;
        }

        public IState GetHasOneDollarState()
        {
            return hasOneDollarState;
        }

        public IState GetOutOfStockState()
        {
            return outOfStockState;
        }

        public int GetCount()
        {
            return count;
        }

        public void DoReturnMoney()
        {
            Console.WriteLine("Money returned");
        }

        public void DoReleaseProduct()
        {
            count--;
            Console.WriteLine($"Product released, Count: {count}");
        }
    }

}
