namespace DesignPatternsLearning.Structural.Composite
{
    // Class Room implementing IStructure
    public class Room : IStructure
    {
        private string name;

        public Room(string name)
        {
            Console.WriteLine($"Creating room: {name}");
            this.name = name;
        }

        public void Enter()
        {
            Console.WriteLine($"Entering the room: {name}");
        }

        public void Exit()
        {
            Console.WriteLine($"Exiting the room: {name}");
        }

        public void Location()
        {
            Console.WriteLine($"Location of the room: {name}");
        }

        public string GetName()
        {
            return name;
        }
    }
}
