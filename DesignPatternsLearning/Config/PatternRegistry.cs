namespace DesignPatternsLearning.Config
{
    public static class PatternRegistry
    {
        private static readonly Dictionary<string, IPattern> Patterns = new Dictionary<string, IPattern>
        {
            { "1", new SingletonPattern() },
            { "2", new FactoryMethodPattern() },
            { "3", new FacadePattern() },
            { "4", new AdapterPattern() },
            { "5", new CompositePattern() },
            { "6", new ProxyPattern() }
        };

        public static IPattern? GetPattern(string? choice)
        {
            if (choice != null && Patterns.ContainsKey(choice))
            {
                return Patterns[choice];
            }

            return null;
        }

        public static void ListPatterns()
        {
            Console.WriteLine("Choose a design pattern to test:");
            Console.WriteLine("1. Singleton");
            Console.WriteLine("2. Factory Method");
            Console.WriteLine("3. Facade");
            Console.WriteLine("4. Adapter");
            Console.WriteLine("5. Composite");
            Console.WriteLine("6. Proxy");
        }
    }
}
