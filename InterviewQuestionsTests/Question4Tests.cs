namespace InterviewQuestionsTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Question4Tests
    {
        [TestMethod]
        public void ReplaceSpacesWorksCorrectly()
        {
            var input = "The quick brown fox";
            var expected = "The%20quick%20brown%20fox";

            var result = InterviewQuestions.Question4.ReplaceSpaces(input);

            Assert.AreEqual(expected, result);
        }
    }
}