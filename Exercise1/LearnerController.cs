﻿using ESFA.DC.Serialization.Json;

namespace Exercise1
{
    public class LearnerController
    {
        public static List<Learner> ImportLearnerJson()
        {
            string jsonFilenameHardcoded = "C:/dev/exercise/Exercise1/Exercise1/Learners/LearnersData.json"; // TODO: Hardcoded, place in a static data file
            string jsonText = File.ReadAllText(jsonFilenameHardcoded);
            var jsonService = new JsonSerializationService();
            var importedlearners = jsonService.Deserialize<List<Learner>>(jsonText);
            return importedlearners;
        }

        public static void ExportLearnerJson(List<Learner> learners)
        {
            string jsonFileNameTargetHardcoded = "C:/dev/exercise/Exercise1/Exercise1/Learners/ExportedLearnersData.json"; // TODO: Hardcoded, place in a static data file
            var jsonService = new JsonSerializationService();
            var jsonString = jsonService.Serialize(learners);
            File.WriteAllText(jsonFileNameTargetHardcoded, jsonString);
            Console.WriteLine("\nLearners data exported successfully  ");
        }

        public static string GetDisplayName(Learner learner)
        {
            if (learner.FamilyName != null && learner.FamilyName != null)
            {
                string displayName = learner.GivenNames + " " + learner.FamilyName;
                return displayName;
            }
            else
            {
                string displayName = "INVALID NAME";
                return displayName;
            }
        }

        private static Learner CreateCustomLearner(string firstName, string lastName, string reference, int accom)
        {
            var customLearner = new Learner
            {
                FamilyName = lastName,
                GivenNames = firstName,
                LearnRefNumber = reference,
                Accom = accom
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
