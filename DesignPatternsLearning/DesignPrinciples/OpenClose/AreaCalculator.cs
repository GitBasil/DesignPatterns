namespace DesignPatternsLearning.DesignPrinciples.OpenClose
{
    public class AreaCalculator
    {
        public double TotalArea(Shape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.CalculateArea();
            }
            return area;
        }
    }
}
