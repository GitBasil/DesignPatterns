namespace DesignPatternsLearning.Behavioral.Template
{
    public class Spaghetti : PastaDish
    {
        protected override void AddPasta()
        {
            Console.WriteLine("Adding spaghetti");
        }

        protected override void AddSauce()
        {
            Console.WriteLine("Adding marinara sauce");
        }

        protected override void AddProtein()
        {
            Console.WriteLine("Adding meatballs");
        }

        protected override void AddGarnish()
        {
            Console.WriteLine("Adding parmesan cheese");
        }
    }
}
