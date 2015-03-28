namespace InterviewQuestions
{
    using System.Linq;

    public static class Question2
    {
        public static string ReverseString(string input)
        {
            var reversed = input.Trim(char.MinValue).Reverse();

            return string.Join(string.Empty, reversed);
        }
    }
}