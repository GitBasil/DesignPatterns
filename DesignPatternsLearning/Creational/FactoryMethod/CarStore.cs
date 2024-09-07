namespace DesignPatternsLearning.Creational.FactoryMethod
{
    public class CarStore : VehicleStore
    {
        protected override Vehicle CreateVehicle()
        {
            return new Car();
        }
    }
}
