namespace InterviewQuestions
{
    using System.Text;

    public static class Question5
    {
        public static string CompressString(string source)
        {
            var compressed = new StringBuilder();
            
            char previous = source[0];
            int count = 0;

            foreach (var chr in source)
            {
                if (chr == previous)
                {
                    count++;
                }
                else
                {
                    AddToStringBuilder(compressed, previous, count);
                    previous= chr;
                    count = 1;
                }
            }

            AddToStringBuilder(compressed, previous, count);

            var compressedString = compressed.ToString();

            return (compressedString.Length >= source.Length)
                ? source
                : compressedString;
        }

        private static void AddToStringBuilder(StringBuilder stringbuilder, char chr, int count)
        {
            stringbuilder.Append(chr.ToString());
            stringbuilder.Append(count);
        }
    }
}