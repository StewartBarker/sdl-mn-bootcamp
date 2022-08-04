using System;

namespace SLDBootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting...\n");

            // Import Learner json Data
            var importedLearners = LearnerController.ImportLearnerJson();
            LearnerController.ValidateListOflearners(importedLearners);

            // Export Learner json Data
            var exportLearners = LearnerController.CreateListOfCustomLearners();
            LearnerController.ExportLearnerJson(exportLearners);
        }
    }

}


