using Validation.Services;

namespace SLDBootcamp
{
    class Program
    {

        LearnerController learnerController { get; set; }

        ValidationService validationService { get; set; }

        public Program()
        {
            // Not sure if the Program class is the most suitable place to initalise these...
            this.learnerController = new LearnerController();
            this.validationService = new ValidationService();
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting...\n");
            Program p = new Program();

            // Import Learner json Data
            var importedLearners = p.learnerController.ImportLearnerJson();
            p.learnerController.ValidateListOflearners(importedLearners);
            var validationMessages = p.validationService.LearnerValidation(importedLearners);
            p.validationService.PrintValidationMessages(validationMessages);

            // Export Learner json Data
            /*
            var exportLearners = p.learnerController.CreateListOfCustomLearners();
            p.learnerController.ExportLearnerJson(exportLearners);
            */
        }
    }

}


