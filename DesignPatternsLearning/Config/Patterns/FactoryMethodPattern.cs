using DesignPatternsLearning.Creational.FactoryMethod;

namespace DesignPatternsLearning.Config
{
    public class FactoryMethodPattern : IPattern
    {
        public void Test()
        {
            VehicleStore carStore = new CarStore();
            VehicleStore bikeStore = new BikeStore();

            // Order a car
            Console.WriteLine("Ordering a Car:");
            carStore.OrderVehicle();

            // Order a bike
            Console.WriteLine("\nOrdering a Bike:");
            bikeStore.OrderVehicle();
        }
    }
}
