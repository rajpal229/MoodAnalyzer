namespace MoodAnalyzerProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checking for Sad");
            MoodAnalyzer moodAnalyzer1 = new MoodAnalyzer("SaD");
            moodAnalyzer1.AnalyzeMood();
        }
    }
}