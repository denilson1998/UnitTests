using Application_Layer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.ControllerTests
{
    public class EmailValidatorTests
    {
        [Fact]
        public void ValidateEmail_InvalidEmail_ShouldReturnFalse()
        {
            // Arrange
            string email = "invalid.email";

            // Act
            bool result = EmailValidator.ValidateEmail(email);

            // Assert
            Assert.False(result); 
        }

        [Fact]
        public void ValidateEmail_ValidEmail_ShouldReturnTrue()
        {
            // Arrange
            string email = "valid@email.com";

            // Act
            bool result = EmailValidator.ValidateEmail(email);

            // Assert
            Assert.True(result);
        }
    }
}
