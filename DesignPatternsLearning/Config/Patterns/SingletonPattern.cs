using DesignPatternsLearning.Creational.Singleton;

namespace DesignPatternsLearning.Config
{
    public class SingletonPattern : IPattern
    {
        public void Test()
        {
            Console.WriteLine("\nTesting Singleton Pattern:");
            Singleton instance1 = Singleton.GetInstance();
            Singleton instance2 = Singleton.GetInstance();

            if (instance1 == instance2)
            {
                Console.WriteLine("Both instances are the same (Singleton works).");
            }
            else
            {
                Console.WriteLine("Instances are different (Singleton failed).");
            }
        }
    }
}
