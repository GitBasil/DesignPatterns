namespace DesignPatternsLearning.Creational.FactoryMethod
{
    public abstract class VehicleStore
    {
        public Vehicle OrderVehicle()
        {
            Vehicle vehicle = CreateVehicle();

            // Perform common steps
            vehicle.Clean();

            // Check if the vehicle is refuelable
            if (vehicle is IRefuelable refuelableVehicle)
            {
                refuelableVehicle.Refuel();
            }

            vehicle.Drive();

            return vehicle;
        }

        // Factory Method to be implemented by concrete stores
        protected abstract Vehicle CreateVehicle();
    }
}
