using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        public const string Happy_Mood = "I am in Happy Mood";
        public const string Sad_Mood = "I am in Sad Mood";
        public string AnalyzeMood(string mood)
        {
            if (mood.ToLower().Contains("happy"))
            {
                Console.WriteLine(Happy_Mood);
                return mood.ToLower();
            }
            if (mood.ToLower().Contains("sad"))
            {
                Console.WriteLine(Sad_Mood);
                return mood.ToLower();
            }
            else
            {
                return null;

            }
        }
    }
}
