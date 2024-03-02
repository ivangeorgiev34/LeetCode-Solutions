namespace _0290.WordPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WordPattern("abba", "dog cat cat dog"));
        }
        public static bool WordPattern(string pattern, string s)
        {
            var dictionary = new Dictionary<char, string>();
            var index = 0;
            var patternIndex = 0;

            string word = "";

            while (index <= s.Length && patternIndex < pattern.Length)
            {
                if (index == s.Length || s[index] == ' ')
                {
                    if (dictionary.ContainsKey(pattern[patternIndex]) == true)
                    {
                        //a dog
                        //b dog
                        if (dictionary[pattern[patternIndex]] != word)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (dictionary.ContainsValue(word) == false)
                        {
                            dictionary.Add(pattern[patternIndex], word);
                        }
                        else
                        {
                            return false;
                        }
                    }

                    patternIndex += 1;
                    word = "";
                }
                else
                {
                    word += s[index];
                }

                index += 1;
            }
            return patternIndex == pattern.Length && index == s.Length + 1;
        }
    }
}