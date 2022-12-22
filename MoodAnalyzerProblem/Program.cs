namespace MoodAnalyzerProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checking for Happy");
            MoodAnalyzer moodAnalyzer1 = new MoodAnalyzer("HapPy");
            moodAnalyzer1.AnalyzeMood();
        }
    }
}