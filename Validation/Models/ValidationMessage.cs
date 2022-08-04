using Validation.Rules;

namespace Validation.Models
{
    public class ValidationMessage
    {
        public string messageBody { get; set; }

        // TODO: Duplicate data?
        public string? giveNames { get; set; }

        public string? familyName { get; set; }

        public string? learnerRef { get; set; }


        public ValidationMessage(Learner learner)
        {
            this.giveNames = (learner.givenNames != null) ? learner.givenNames : "No given names supplied";
            this.familyName = (learner.familyName != null) ? learner.familyName : "No family name supplied";
            this.learnerRef = (learner.learnRefNumber != null) ? learner.learnRefNumber : "No Learner Reference number supplied";
            this.messageBody = GenerateValidationMessage(learner);
            
        }

        private string GenerateValidationMessage(Learner learner)
        {
            var learnerIsValid = Accom_1.VerifyAccom(learner);
            if (learnerIsValid)
            {
                string messageBody = string.Empty;
            } else
            {
                string messageBody = $"The following learner is invalid:\n" +
                    $"First Name: {this.giveNames}\n" +
                    $"Last Name: {this.familyName}\n" +
                    $"Learner Ref Number: {this.learnerRef}\n";
            }
            return messageBody;
        }
    }
}
