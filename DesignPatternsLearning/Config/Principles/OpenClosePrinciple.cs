// Explanation:
// Shape Class: This is the abstract base class that defines the contract (CalculateArea method) for all shapes. It is open for extension, meaning you can add new shapes (e.g., Triangle, Square) without modifying it.
// Rectangle and Circle: These classes inherit from Shape and provide their own implementations of the CalculateArea method. If you add new shapes like Triangle, you just need to add a new class that extends Shape.
// AreaCalculator Class: This class calculates the total area for any collection of shapes without being modified when new shapes are added.
// Program Class: The entry point of the application where different shapes are instantiated and the total area is calculated.
// This structure adheres to the Open/Closed Principle since you can add new shapes by creating new classes without changing the existing code in Shape, Rectangle, Circle, or AreaCalculator.



using DesignPatternsLearning.DesignPrinciples.OpenClose;

namespace DesignPatternsLearning.Config
{
    public class OpenClosePrinciple : IPattern
    {
        public void Test()
        {
            Shape[] shapes = new Shape[]
            {
                new Rectangle(5, 6),
                new Circle(3)
            };

            AreaCalculator calculator = new AreaCalculator();
            double totalArea = calculator.TotalArea(shapes);

            Console.WriteLine($"The total area of all shapes is: {totalArea}");
        }
    }
}
