namespace DesignPatternsLearning.Behavioral.Template
{
    public abstract class PastaDish
    {
        public void MakeRecipe()
        {
            BoilWater();
            AddPasta();
            CookPasta();
            DrainAndPlate();
            AddSauce();
            AddProtein();
            AddGarnish();
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void CookPasta()
        {
            Console.WriteLine("Cooking pasta");
        }

        private void DrainAndPlate()
        {
            Console.WriteLine("Draining and plating the pasta");
        }

        // Abstract methods that must be implemented by subclasses
        protected abstract void AddPasta();
        protected abstract void AddSauce();
        protected abstract void AddProtein();
        protected abstract void AddGarnish();
    }
}
