using System.Reflection.Metadata.Ecma335;

namespace Application_Layer.Classes
{
    public class CircleAreaCalculator
    {
        public static double CalculateArea(double radius)
        {
            // Utiliza la fórmula del área de un círculo: A = π * r^2
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be greater than 0!");
            }
            else
            {
                return Math.PI * Math.Pow(radius, 2);
            }
        }
    }
}
