namespace _0058.LengthOfLastWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLastWord("Hello World");
        }

        public static int LengthOfLastWord(string s)
        {
            var lastWordStartIndex = 0;
            var lastWordEndIndex = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ' && lastWordEndIndex == 0)
                {
                    lastWordEndIndex = i;
                    continue;
                }

                if (s[i] == ' ' && lastWordEndIndex != 0)
                {
                    lastWordStartIndex = i + 1;
                    break;
                }
            }

            return lastWordEndIndex - lastWordStartIndex + 1;
        }
    }
}
