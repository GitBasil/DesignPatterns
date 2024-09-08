namespace DesignPatternsLearning.Structural.Composite
{
    // Class Housing implementing IStructure
    public class Housing : IStructure
    {
        private string address;
        private List<IStructure> structures;

        public Housing(string address)
        {
            Console.WriteLine($"Creating housing: {address}");
            this.address = address;
            structures = new List<IStructure>();
        }

        public void Enter()
        {
            Console.WriteLine($"Entering the housing: {address}");
            foreach (var structure in structures)
            {
                structure.Enter();
            }
        }

        public void Exit()
        {
            Console.WriteLine($"Exiting the housing: {address}");
            foreach (var structure in structures)
            {
                structure.Exit();
            }
        }

        public void Location()
        {
            Console.WriteLine($"Location of the housing: {address}");
            foreach (var structure in structures)
            {
                structure.Location();
            }
        }

        public string GetName()
        {
            return address;
        }

        public void AddStructure(IStructure structure)
        {
            structures.Add(structure);
            Console.WriteLine($"Structure {structure.GetName()} added to housing.");
        }

        public IStructure? GetStructure(int index)
        {
            if (index < 0 || index >= structures.Count)
            {
                Console.WriteLine("Invalid index");
                return null;
            }
            return structures[index];
        }
    }
}
