using Validation.Models;
using Validation.Rules;
using ESFA.DC.Serialization.Json;

namespace SLDBootcamp
{
    public class LearnerController
    {
        public static List<Learner> ImportLearnerJson()
        {
            string jsonFilenameHardcoded = "C:/dev/exercise/SLDBootcamp/SLDBootcamp/Learners/LearnersData.json"; // TODO: Hardcoded, place in a static data file
            string jsonText = File.ReadAllText(jsonFilenameHardcoded);
            var jsonService = new JsonSerializationService();
            var importedlearners = jsonService.Deserialize<List<Learner>>(jsonText);
            return importedlearners;
        }

        public static void ExportLearnerJson(List<Learner> learners)
        {
            string jsonFileNameTargetHardcoded = "C:/dev/exercise/SLDBootcamp/SLDBootcamp/Learners/ExportedLearnersData.json"; // TODO: Hardcoded, place in a static data file
            var jsonService = new JsonSerializationService();
            var jsonString = jsonService.Serialize(learners);
            File.WriteAllText(jsonFileNameTargetHardcoded, jsonString);
            Console.WriteLine("\nLearners data exported successfully  ");
        }

        private static Learner CreateCustomLearner(string firstName, string lastName, string reference, int accom)
        {
            var customLearner = new Learner
            {
                familyName = lastName,
                givenNames = firstName,
                learnRefNumber = reference,
                accom = accom
            };

            return customLearner;
        }

        public static List<Learner> CreateListOfCustomLearners()
        {
            var exportLearners = new List<Learner>();
            Learner customLearner1 = CreateCustomLearner("Mary", "Sterling", "ref123", 1);
            exportLearners.Add(customLearner1);
            Learner customLearner2 = CreateCustomLearner("George", "Smith", "ref456", 0);
            exportLearners.Add(customLearner2);

            return exportLearners;
        }

        public static void ValidateListOflearners(List<Learner> listOfLearners)
        {
            foreach (var learner in listOfLearners)
            {
                Accom_1.CheckLearnerValidity(learner);
            }
        }
    }
}
