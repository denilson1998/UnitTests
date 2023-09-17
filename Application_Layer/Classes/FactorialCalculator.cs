namespace Application_Layer.Classes
{
    public class FactorialCalculator
    {
        public static int CalculateFactorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Factorial is not define to negative numbers.");
            }

            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
