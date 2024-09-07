using DesignPatternsLearning.Config;

namespace DesignPatternsLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            PatternRegistry.ListPatterns();
            Console.Write("Enter the number of the pattern to test: ");
            string? choice = Console.ReadLine();

            IPattern? pattern = PatternRegistry.GetPattern(choice);
            if (pattern != null)
            {
                pattern.Test();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}
