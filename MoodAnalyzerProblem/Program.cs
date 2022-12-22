namespace MoodAnalyzerProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Handle Exception");
            MoodAnalyzer moodAnalyzer1 = new MoodAnalyzer();
            moodAnalyzer1.AnalyzeMood();
        }
    }
}