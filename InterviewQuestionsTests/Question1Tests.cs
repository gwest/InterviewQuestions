namespace InterviewQuestionsTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Question1Tests
    {
        [TestMethod]
        public void ReturnFalseForStringLongerThan256Characters()
        {
            var input = "hmIz0J4A4o6QaBMDsaZin5DWLknvKr50KJqloEBwSpcwy8E80T0S2qmvf8qjiYFS9qAoZBbbgfvLLXGcPsbAPeqYOqhiCCcWFyPvGWYCQHgZ7yYe6T9Ks5TsBVPT8AH3iSe1M31yMyP9UF2ZK2WpyMBKplceQwJogFUWE3jBoCkMej8imNJyMPjS8YqhaQP78iGC6PWrEOLjefnaXNrOw5o565mMkUVqPjKWz9kZ5z5m6qaaAH0NNa0QvP9GCw52M";

            var result = InterviewQuestions.Question1.AreCharactersUnique(input);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ReturnFalseForStringWithMatchingCharaters()
        {
            var input = "ABCDEFA";

            var result = InterviewQuestions.Question1.AreCharactersUnique(input);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ReturnTrueForStringWithUniqueCharaters()
        {
            var input = "ABCDEFG";

            var result = InterviewQuestions.Question1.AreCharactersUnique(input);

            Assert.IsTrue(result);
        }
    }
}
