using Validation.Rules;

namespace Validation.Models
{
    public class ValidationMessage
    {
        public string messageBody { get; set; }

        // Q: Duplicate data?
        public string? giveNames { get; set; }

        public string? familyName { get; set; }

        public string? learnerRef { get; set; }

        private Accom_1 _accom_1Rule;


        public ValidationMessage(Learner learner)
        {
            this._accom_1Rule = new Accom_1();
            this.giveNames = (learner.givenNames != null) ? learner.givenNames : "No given names supplied";
            this.familyName = (learner.familyName != null) ? learner.familyName : "No family name supplied";
            this.learnerRef = (learner.learnRefNumber != null) ? learner.learnRefNumber : "No Learner Reference number supplied";
            this.messageBody = GenerateValidationMessage(learner);     
        }

        private string GenerateValidationMessage(Learner learner)
        {
            string messageBody;
            var learnerIsValid = this._accom_1Rule.VerifyAccom(learner);
            if (learnerIsValid)
            {
                messageBody = "";
            } else
            {
                messageBody = $"\nThe following learner is invalid:\n" +
                    $"First Name: {this.giveNames}\n" +
                    $"Last Name: {this.familyName}\n" +
                    $"Learner Ref Number: {this.learnerRef}\n";
            }
            return messageBody;
        }
    }
}
