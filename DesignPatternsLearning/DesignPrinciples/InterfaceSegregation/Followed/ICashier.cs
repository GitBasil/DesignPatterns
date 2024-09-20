namespace DesignPatternsLearning.InterfaceSegregation.DependencyInversion
{
    public interface ICashier
    {
        void ScanItem();
        void TakePayment();
        void DispenseChange();
    }
}