namespace DesignPatternsLearning.Creational.Singleton
{
    public class Singleton
    {
        private static Singleton? _instance;

        // Private constructor to prevent instantiation from outside
        private Singleton() { }

        // Method to get the single instance of the class
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
