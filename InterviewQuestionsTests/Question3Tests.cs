namespace InterviewQuestionsTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Question3Tests
    {
        [TestMethod]
        public void IsPermutation()
        {
            var source = "ABCDEFG";
            var search = "ECFABDG";

            var result = InterviewQuestions.Question3.IsPermutation(source, search);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNotPermutation()
        {
            var source = "ABCDEFG";
            var search = "ECFXYZS";

            var result = InterviewQuestions.Question3.IsPermutation(source, search);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsNotPermutationAsNotSameLength()
        {
            var source = "ABCDEFG";
            var search = "ECFXYZ";

            var result = InterviewQuestions.Question3.IsPermutation(source, search);

            Assert.IsFalse(result);
        }
    }
}