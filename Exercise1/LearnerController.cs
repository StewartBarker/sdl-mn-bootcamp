using Validation.Models;
using Validation.Rules;
using Validation.Services;
using ESFA.DC.Serialization.Json;

namespace SLDBootcamp
{
    public class LearnerController
    {
        private Accom_1 _accom_1Rule;
        private ValidationService _validationService;

        public LearnerController()
        {
            this._accom_1Rule = new Accom_1();
            this._validationService = new ValidationService();
        }

        public List<Learner> ImportLearnerJson()
        {
            string jsonFilenameHardcoded = "Learners/LearnersData.json";
            string jsonText = File.ReadAllText(jsonFilenameHardcoded);
            var jsonService = new JsonSerializationService();
            var importedlearners = jsonService.Deserialize<List<Learner>>(jsonText);
            return importedlearners;
        }

        public void ExportLearnerJson(List<Learner> learners)
        {
            string jsonFileNameTargetHardcoded = "Learners/ExportedLearnersData.json"; 
            var jsonService = new JsonSerializationService();
            var jsonString = jsonService.Serialize(learners);
            File.WriteAllText(jsonFileNameTargetHardcoded, jsonString);
            Console.WriteLine("\nLearners data exported successfully  ");
        }

        private Learner CreateCustomLearner(string firstName, string lastName, string reference, int accom)
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

        public List<Learner> CreateListOfCustomLearners()
        {
            var exportLearners = new List<Learner>();
            Learner customLearner1 = CreateCustomLearner("Mary", "Sterling", "ref123", 1);
            exportLearners.Add(customLearner1);
            Learner customLearner2 = CreateCustomLearner("George", "Smith", "ref456", 0);
            exportLearners.Add(customLearner2);

            return exportLearners;
        }

        public void ValidateListOflearners(List<Learner> listOfLearners)
        {
            foreach (var learner in listOfLearners)
            {
                this._accom_1Rule.CheckLearnerValidity(learner);
            }
            // Q: Should the following 2 lines be in their own method?
            var validationMessages = this._validationService.LearnerValidation(this._accom_1Rule.invalidLearnerList);
            this._validationService.PrintValidationMessages(validationMessages);
        }
    }
}
