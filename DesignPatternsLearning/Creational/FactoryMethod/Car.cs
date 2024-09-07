namespace DesignPatternsLearning.Creational.FactoryMethod
{
    public class Car : Vehicle, IRefuelable
    {
        public override void Drive() => Console.WriteLine("Driving a car.");
        public override void Clean() => Console.WriteLine("Cleaning a car.");

        public void Refuel() => Console.WriteLine("Refueling a car.");
    }
}
