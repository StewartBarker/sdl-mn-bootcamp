using Validation.Services;

namespace SLDBootcamp
{
    class Program
    {

        LearnerController learnerController { get; set; }

        public Program()
        {
            this.learnerController = new LearnerController();
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting...\n");
            Program p = new Program();

            // Import Learner json Data
            var importedLearners = p.learnerController.ImportLearnerJson();
            p.learnerController.ValidateListOflearners(importedLearners);

            // Export Learner json Data
            var exportLearners = p.learnerController.CreateListOfCustomLearners();
            p.learnerController.ExportLearnerJson(exportLearners);
        }
    }

}


