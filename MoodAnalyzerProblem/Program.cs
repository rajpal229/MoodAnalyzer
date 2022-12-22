namespace MoodAnalyzerProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checking for Happy");
            MoodAnalyzer moodAnalyzer =new MoodAnalyzer("HaPPy");
            moodAnalyzer.AnalyzeMood();

            Console.WriteLine("\nChecking for Sad");
            MoodAnalyzer moodAnalyzer1 = new MoodAnalyzer("SaD");
            moodAnalyzer1.AnalyzeMood();

            Console.WriteLine("\nChecking for Any other input");
            MoodAnalyzer moodAnalyzer2 = new MoodAnalyzer("sasd");
            moodAnalyzer2.AnalyzeMood();
        }
    }
}