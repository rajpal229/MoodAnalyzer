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
        const string NULL = "Mood can't be Null";
        public string mood;
        public MoodAnalyzer() 
        {

        }
        public MoodAnalyzer(string mood)
        {
            this.mood = mood;
        }
        
        public string AnalyzeMood()
        {
            try
            {
                if (this.mood.ToLower().Contains("happy"))
                {
                    Console.WriteLine(Happy_Mood);
                    return mood.ToLower();
                }
                else if (this.mood.ToLower().Contains("sad"))
                {
                    Console.WriteLine(Sad_Mood);
                    return mood.ToLower();
                }
                else
                {
                    throw new Exception("Exception: Invalid Input");
                    return null;
                }
            }
            catch (System.NullReferenceException ex)
            {
                Console.WriteLine(Happy_Mood);
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
