// In this example:

// The base class Bird assumes all birds can fly.
// The Sparrow class correctly inherits the behavior from Bird and can fly.
// However, the Penguin class violates the Liskov Substitution Principle by overriding the Fly method with an exception, breaking the expected behavior (all birds can fly).
// To fix the violation, you would need to rethink the design, possibly by not including Penguin in the Bird class hierarchy if "flying" is a requirement for the Bird class.

using DesignPatternsLearning.DesignPrinciples.LSP;

namespace DesignPatternsLearning.Config
{
    public class LSPPrinciple : IPattern
    {
        public void Test()
        {
            Bird sparrow = new Sparrow();
            Bird penguin = new Penguin();

            sparrow.Fly();   // Output: The sparrow flies.
            penguin.Fly();   // Throws an exception: Penguins cannot fly.
        }
    }
}
