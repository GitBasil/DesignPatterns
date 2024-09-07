namespace DesignPatternsLearning.Creational.FactoryMethod
{
    public class Bike : Vehicle
    {
        public override void Drive() => Console.WriteLine("Riding a bike.");
        public override void Clean() => Console.WriteLine("Cleaning a bike.");
    }
}
