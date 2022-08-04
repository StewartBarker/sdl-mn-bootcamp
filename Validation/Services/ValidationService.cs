using Validation.Models;

namespace Validation.Services
{
    public class ValidationService
    {
        public IEnumerable<ValidationMessage> LearnerValidation(IEnumerable<Learner> learners)
        {
            var messageList = new List<ValidationMessage>();
            foreach (Learner learner in learners)
            {
                var learnerValidationMessage = new ValidationMessage(learner);
                messageList.Add(learnerValidationMessage);
            }
            IEnumerable<ValidationMessage> IEnumMessages = messageList;

            return IEnumMessages;
        }

        public void PrintValidationMessages(IEnumerable<ValidationMessage> validationMessages)
        {
            foreach(var validationMessage in validationMessages)
            {
                Console.WriteLine(validationMessage.messageBody);
            }
        }
    }
}
