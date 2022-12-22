using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        const string Happy_Mood = "I am in Happy Mood";
        const string Sad_Mood = "I am in Sad Mood";
        const string NULL = "Mood is null";
        public string mood;
        public MoodAnalyzer() 
        {

        }
        public MoodAnalyzer(string mood)
        {
            this.mood = mood;
            this.mood = mood;
        }
        
        public string AnalyzeMood()
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
                return NULL;
            }
        }
    }
}
