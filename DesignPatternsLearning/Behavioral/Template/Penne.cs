namespace DesignPatternsLearning.Behavioral.Template
{
    public class Penne : PastaDish
    {
        protected override void AddPasta()
        {
            Console.WriteLine("Adding penne pasta");
        }

        protected override void AddSauce()
        {
            Console.WriteLine("Adding alfredo sauce");
        }

        protected override void AddProtein()
        {
            Console.WriteLine("Adding grilled chicken");
        }

        protected override void AddGarnish()
        {
            Console.WriteLine("Adding parsley");
        }
    }
}
