
using Application_Layer.Classes;

namespace UnitTests.ControllerTests
{
    public class FactorialCalculatorTest
    {
        [Fact]
        public void CalculateFactorial_OfNegative_ShouldReturnOne()
        {
            // Arrange
            int number = -1;

            // Act
            int result = FactorialCalculator.CalculateFactorial(number);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void CalculateFactorial_OfFive_ShouldReturn120()
        {
            // Arrange
            int number = 5;

            // Act
            int result = FactorialCalculator.CalculateFactorial(number);

            // Assert
            Assert.Equal(120, result);
        }
    }
}