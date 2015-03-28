namespace InterviewQuestions
{
    using System.Collections.Generic;

    public static class Question1
    {
        public static bool AreCharactersUnique(string input)
        {
            if (input.Length > 256)
            {
                return false;
            }

            var chars = new List<int>();

            foreach (var character in input)
            {
                if (chars.Contains(character))
                {
                    return false;
                }

                chars.Add(character);
            }

            return true;
        }
    }
}
