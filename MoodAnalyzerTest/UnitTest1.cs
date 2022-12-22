using MoodAnalyzerProblem;


namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodReturnSAD()
        {
            //Arrange
            MoodAnalyzer analyzer = new MoodAnalyzer();

            //Act
            string actualoutput = analyzer.AnalyzeMood("Sad");
            string expectedoutput = "sad";

            //Assert
            Assert.AreEqual(expectedoutput, actualoutput);
        }
        [TestMethod]
        public void GivenHappyMoodReturnHAPPY()
        {
            //Arrange
            MoodAnalyzer analyzer = new MoodAnalyzer();

            //Act
            string actualoutput = analyzer.AnalyzeMood("Happy");
            string expectedoutput = "happy";

            //Assert
            Assert.AreEqual(expectedoutput, actualoutput);
        }
    }
}