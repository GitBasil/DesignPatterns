namespace DesignPatternsLearning.DesignPrinciples.DependencyInversion
{
    public class ClientSubsystem
    {
        private ISorting _sorting;

        public ClientSubsystem(ISorting sorting)
        {
            _sorting = sorting; // Injecting dependency
        }

        public void SortInput(List<int> data)
        {
            _sorting.Sort(data); // Uses the injected sorting algorithm
        }
    }
}