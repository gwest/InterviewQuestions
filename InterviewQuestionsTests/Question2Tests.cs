namespace InterviewQuestionsTests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Question2Tests
    {
        [TestMethod]
        public void ReturnReversedString()
        {
            var input = "ABCDEFG";
            var expected = "GFEDCBA";

            var result = InterviewQuestions.Question2.ReverseString(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReturnReversedStringForNullEndingString()
        {
            var input = "ABCDEFG" + Char.MinValue;
            var expected = "GFEDCBA";

            var result = InterviewQuestions.Question2.ReverseString(input);

            Assert.AreEqual(expected, result);
        }
    }
}