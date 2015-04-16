namespace InterviewQuestionsTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Question5Tests
    {
        [TestMethod]
        public void CompressStringWorks()
        {
            var input = "aaabccccdddddeff";
            var expected = "a3b1c4d5e1f2";

            var result = InterviewQuestions.Question5.CompressString(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CompressStringReturnsOriginal()
        {
            var input = "abcdef";

            var result = InterviewQuestions.Question5.CompressString(input);

            Assert.AreEqual(input, result);
        }
    }
}