namespace _0392.IsSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsSubsequence("b", "abc"));
        }

        public static bool IsSubsequence(string s, string t)
        {
            if (s == "")
            {
                return true;
            }

            var subsequenceIndex = 0;
            var i = 0;

            while (i < t.Length && subsequenceIndex < s.Length)
            {
                if (t[i] == s[subsequenceIndex])
                {
                    subsequenceIndex += 1;
                }

                i += 1;
            }

            return subsequenceIndex == s.Length;
        }
    }
}
