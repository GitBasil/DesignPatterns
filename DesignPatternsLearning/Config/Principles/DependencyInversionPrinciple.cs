using DesignPatternsLearning.DesignPrinciples.DependencyInversion;

namespace DesignPatternsLearning.Config
{
    public class DependencyInversionPrinciple : IPattern
    {
        public void Test()
        {
            List<int> data = new List<int> { 5, 2, 8, 3 };

            // Using MergeSort
            ClientSubsystem clientWithMergeSort = new ClientSubsystem(new MergeSort());
            clientWithMergeSort.SortInput(data);

            // Using QuickSort
            ClientSubsystem clientWithQuickSort = new ClientSubsystem(new QuickSort());
            clientWithQuickSort.SortInput(data);
        }
    }
}