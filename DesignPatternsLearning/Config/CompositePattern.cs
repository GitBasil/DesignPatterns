using DesignPatternsLearning.Structural.Composite;

namespace DesignPatternsLearning.Config
{
    public class CompositePattern : IPattern
    {
        public void Test()
        {
            // Create rooms for the first floor
            Room livingRoom = new Room("Living Room");
            Room kitchen = new Room("Kitchen");

            // Create rooms for the second floor
            Room bedroom = new Room("Bedroom");
            Room bathroom = new Room("Bathroom");

            // Create first floor and add rooms
            Housing firstFloor = new Housing("First Floor");
            firstFloor.AddStructure(livingRoom);
            firstFloor.AddStructure(kitchen);

            // Create second floor and add rooms
            Housing secondFloor = new Housing("Second Floor");
            secondFloor.AddStructure(bedroom);
            secondFloor.AddStructure(bathroom);

            // Create a house that contains the first and second floors
            Housing house = new Housing("123 Main Street");
            house.AddStructure(firstFloor);
            house.AddStructure(secondFloor);

            // Simulate actions on the house
            house.Enter();
            house.Location();
            house.Exit();
        }
    }
}
