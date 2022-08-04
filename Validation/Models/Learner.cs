namespace Validation.Models
{
    public class Learner
    {
        public string familyName { get; set; }

        public string givenNames { get; set; }

        public string learnRefNumber { get; set; }

        public int? accom { get; set; }

        public virtual ValidationMessage validationMessage { get; set; }

        public static void Hello()
        {
            Console.WriteLine("Hello from inside class");
        }
    }
}
