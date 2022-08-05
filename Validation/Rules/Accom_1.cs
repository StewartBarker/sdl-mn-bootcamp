using Validation.Models;
using Validation.Services;

namespace Validation.Rules
{
    public class Accom_1
    {
        private ValidationService _validationService;
        public List<Learner> invalidLearnerList { get; set; }

        public Accom_1()
        {
            this._validationService = new ValidationService();
            this.invalidLearnerList = new List<Learner>();
        }

        public void CheckLearnerValidity (Learner learnerToCheck)
        {
            bool validityStatus = this.VerifyAccom(learnerToCheck);
            string displayName = GetDisplayName(learnerToCheck);
            DisplayValidityMessage(displayName, validityStatus);
        }

        public bool VerifyAccom(Learner learnerToCheck)
        {
            bool status = (learnerToCheck.accom == 1) ? true : false;
            if (!status)
            {
                this.invalidLearnerList.Add(learnerToCheck);
            }
            return status;
        }
        
        public static void DisplayValidityMessage(string displayName, bool validityStatus)
        {

            if (validityStatus)
            {
                string message = "Learner " + displayName + " is valid";
                Console.WriteLine(message);
            }
            else
            {
                string message = "Learner " + displayName + " is invalid";
                Console.WriteLine(message);
            }
        }

        public static string GetDisplayName(Learner learner)
        {
            if (learner.familyName != null && learner.familyName != null)
            {
                string displayName = learner.givenNames + " " + learner.familyName;
                return displayName;
            }
            else
            {
                string displayName = "INVALID NAME";
                return displayName;
            }
        }
    }
}
