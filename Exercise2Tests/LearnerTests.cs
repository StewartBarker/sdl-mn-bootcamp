using Exercise1;

namespace Exercise2Tests
{
    public class LearnerTests
    {
        [Fact]
        public void Initialise_NotNull()
        {
            // Arrange & Act
            var learner = new Exercise1.Learner
            {
                FamilyName = "Sterling",
                GivenNames = "Ann",
                LearnRefNumber = "Ref789",
                Accom = 1
            };
            // Assert
            Assert.NotNull(learner);
        }
    }
}