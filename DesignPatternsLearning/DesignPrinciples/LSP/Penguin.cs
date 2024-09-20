
namespace DesignPatternsLearning.DesignPrinciples.LSP
{
    public class Penguin : Bird
    {
        public override void Fly()
        {
            throw new InvalidOperationException("Penguins cannot fly.");
        }
    }
}