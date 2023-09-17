using Application_Layer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.ControllerTests
{
    public class CircleAreaCalculatorTest
    {
        [Fact]
        public void CalculateArea_WithRadiusZero_ShouldReturnZero()
        {
            // Arrange
            double radius = 0;

            // Act
            double result = CircleAreaCalculator.CalculateArea(radius);

            // Assert
            Assert.Equal(0, result, 2);
        }

        [Fact]
        public void CalculateArea_WithRadiusFive_ShouldReturnCorrectValue()
        {
            // Arrange
            double radius = 5;

            // Act
            double result = CircleAreaCalculator.CalculateArea(radius);

            // Assert
            Assert.Equal(78.54, result, 2);
        }
    }
}
