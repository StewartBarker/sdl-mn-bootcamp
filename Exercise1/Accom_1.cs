namespace Exercise1
{
    public class Accom_1
    {
        public static void CheckLearnerValidity (Learner learnerToCheck)
        {
            bool validityStatus = VerifyAccom(learnerToCheck);
            string displayName = LearnerController.GetDisplayName(learnerToCheck);
            DisplayValidityMessage(displayName, validityStatus);
        }

        public static bool VerifyAccom(Learner learnerToCheck)
        {
            bool status = (learnerToCheck.Accom == 1) ? true : false;
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
    }
}
