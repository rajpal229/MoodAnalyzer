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
            MoodAnalyzer analyzer = new MoodAnalyzer("Sad");

            //Act
            string actualoutput = analyzer.AnalyzeMood();
            string expectedoutput = "sad";

            //Assert
            Assert.AreEqual(expectedoutput, actualoutput);
        }
        [TestMethod]
        public void GivenHappyMoodReturnHAPPY()
        {
            //Arrange
            MoodAnalyzer analyzer = new MoodAnalyzer("Happy");

            //Act
            string actualoutput = analyzer.AnalyzeMood();
            string expectedoutput = "happy";

            //Assert
            Assert.AreEqual(expectedoutput, actualoutput);
        }
    }
}