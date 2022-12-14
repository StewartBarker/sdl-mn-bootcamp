using Validation.Models;
using Validation.Rules;

namespace SLDBootcamp.Tests
{
    public class Accom_1Tests
    {
        [Fact]
        public void Validate_True()
        {
            // Arrange
            var accom_1 = new Accom_1();
            var testLearner = new Learner
            {
                familyName = "Sterling",
                givenNames = "Ann",
                learnRefNumber = "Ref789",
                accom = 1
            };

            // Act
            bool validityStatus = accom_1.VerifyAccom(testLearner);
            // Assert
            Assert.True(validityStatus);
        }

        [Fact]
        public void Validate_Accom_01_False()
        {
            // Arrange
            var accom_1 = new Accom_1();
            var testLearner = new Learner
            {
                familyName = "Kayne",
                givenNames = "Rob",
                learnRefNumber = "Ref456",
                accom = 0
            };
            // Act
            bool validityStatus = accom_1.VerifyAccom(testLearner);
            // Assert
            Assert.False(validityStatus);
        }
    }
}
