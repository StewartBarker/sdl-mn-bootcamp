using Validation.Models;
using Validation.Services;

namespace Validation.Tests
{
    public class ValidationServiceTests
    {
        [Fact]
        public void LearnerValidation_ValidLearners_EmptyList()
        {
            // Arrange
            var learnerList = new List<Learner>();
            var validationService = new ValidationService();
            var testLearner = new Learner
            {
                familyName = "Kayne",
                givenNames = "Rob",
                learnRefNumber = "Ref456",
                accom = 1
            };
            learnerList.Add(testLearner);
            IEnumerable<Learner> IEnumLearnerList = learnerList;
            // Act
            var validationMessages = validationService.LearnerValidation(IEnumLearnerList);
            // Assert
            string expctedMessageBody = "";
            Assert.Equal(validationMessages.First().messageBody, expctedMessageBody);
        }

        [Fact]
        public void LearnerValidation_InvalidLearners_ValidationMessage()
        {
            // Arrange
            var learnerList = new List<Learner>();
            var validationService = new ValidationService();
            var testLearner = new Learner
            {
                familyName = "Kayne",
                givenNames = "Rob",
                learnRefNumber = "Ref456",
                accom = 0
            };
            learnerList.Add(testLearner);
            IEnumerable<Learner> IEnumLearnerList = learnerList;
            // Act
            var validationMessages = validationService.LearnerValidation(IEnumLearnerList);
            // Assert
            string expectedMessageBody = $"\nThe following learner is invalid:\n" +
                    $"First Name: Rob\n" +
                    $"Last Name: Kayne\n" +
                    $"Learner Ref Number: Ref456\n";
            Assert.Equal(validationMessages.First().messageBody, expectedMessageBody);
        }
    }
}