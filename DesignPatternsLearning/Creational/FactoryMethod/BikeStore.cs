namespace DesignPatternsLearning.Creational.FactoryMethod
{
    public class BikeStore : VehicleStore
    {
        protected override Vehicle CreateVehicle()
        {
            return new Bike();
        }
    }
}
