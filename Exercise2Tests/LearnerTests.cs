using Validation.Models;

namespace Exercise2Tests
{
    public class LearnerTests
    {
        [Fact]
        public void Initialise_NotNull()
        {
            // Arrange & Act
            var learner = new Learner
            {
                familyName = "Sterling",
                givenNames = "Ann",
                learnRefNumber = "Ref789",
                accom = 1
            };
            // Assert
            Assert.NotNull(learner);
        }
    }
}