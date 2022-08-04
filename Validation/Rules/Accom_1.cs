using Validation.Models;

namespace Validation.Rules
{
    public class Accom_1
    {
        public static void CheckLearnerValidity (Learner learnerToCheck)
        {
            bool validityStatus = VerifyAccom(learnerToCheck);
            string displayName = GetDisplayName(learnerToCheck);
            DisplayValidityMessage(displayName, validityStatus);
        }

        public static bool VerifyAccom(Learner learnerToCheck)
        {
            bool status = (learnerToCheck.accom == 1) ? true : false;
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
