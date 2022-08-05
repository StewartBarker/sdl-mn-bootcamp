using Validation.Services;

namespace SLDBootcamp
{
    class Program
    {

        private LearnerController _learnerController { get; set; }

        public Program()
        {
            // Q: Not sure if the Program class is the most suitable place to initalise these...
            this._learnerController = new LearnerController();
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting...\n");
            Program p = new Program();

            // Import Learner json Data
            var importedLearners = p._learnerController.ImportLearnerJson();
            p._learnerController.ValidateListOflearners(importedLearners);

            // Export Learner json Data
            /*
            var exportLearners = p.learnerController.CreateListOfCustomLearners();
            p.learnerController.ExportLearnerJson(exportLearners);
            */
        }
    }

}


