using DesignPatternsLearning.Behavioral.Template;

namespace DesignPatternsLearning.Config
{
    public class TemplatePattern : IPattern
    {
        public void Test()
        {
            PastaDish spaghetti = new Spaghetti();
            PastaDish penne = new Penne();

            Console.WriteLine("Making Spaghetti:");
            spaghetti.MakeRecipe();

            Console.WriteLine();

            Console.WriteLine("Making Penne:");
            penne.MakeRecipe();
        }
    }
}