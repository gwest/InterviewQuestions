namespace InterviewQuestions
{
    using System.Linq;

    public static class Question3
    {
        public static bool IsPermutation(string source, string search)
        {
            if (source.Length != search.Length)
            {
                return false;
            }

            var sourceArray = source.ToCharArray().OrderBy(x => x);
            var searchArray = search.ToCharArray().OrderBy(x => x);

            if (!sourceArray.SequenceEqual(searchArray))
            {
                return false;
            }

            return true;
        }
    }
}