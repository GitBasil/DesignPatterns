namespace DesignPatternsLearning.DesignPrinciples.DependencyInversion.Violation
{
    public class ClientSubsystem
    {
        private MergeSort _mergeSort;

        public ClientSubsystem()
        {
            _mergeSort = new MergeSort(); // Directly depends on MergeSort
        }

        public void SortInput(List<int> data)
        {
            _mergeSort.Sort(data); // Calls the method of a concrete class
        }
    }
}