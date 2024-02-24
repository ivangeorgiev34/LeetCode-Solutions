namespace _0383.RansomNote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CanConstruct("aa", "aab"));
        }

        public static bool CanConstruct(string ransomNote, string magazine)
        {
            var dictionary = new Dictionary<char, int>();
            var magazineIndex = 0;

            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (dictionary.ContainsKey(ransomNote[i]) == false)
                {
                    dictionary.Add(ransomNote[i], 0);
                }

                dictionary[ransomNote[i]] += 1;
            }


            while (magazineIndex < magazine.Length)
            {
                if (dictionary.ContainsKey(magazine[magazineIndex]))
                {
                    if (dictionary[magazine[magazineIndex]] > 1)
                    {
                        dictionary[magazine[magazineIndex]] -= 1;
                    }
                    else
                    {
                        dictionary.Remove(magazine[magazineIndex]);
                    }
                }

                magazineIndex += 1;
            }

            return dictionary.Count == 0;
        }
    }
}
