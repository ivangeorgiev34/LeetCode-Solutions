namespace _0242.ValidAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsAnagram("anagram", "nagaram"));
        }

        public static bool IsAnagram(string s, string t)
        {

            if (s.Length != t.Length)
            {
                return false;
            }

            var index = 0;
            var dictionary = new Dictionary<char, int>();

            while (index < s.Length)
            {
                if (dictionary.ContainsKey(s[index]) == false)
                {
                    dictionary.Add(s[index], 0);
                }

                dictionary[s[index]] += 1;

                index += 1;
            }

            index = 0;

            while (index < t.Length)
            {
                if (dictionary.ContainsKey(t[index]) == false)
                {
                    return false;
                }
                else
                {
                    if (dictionary[t[index]] == 1)
                    {
                        dictionary.Remove(t[index]);
                    }
                    else
                    {
                        dictionary[t[index]] -= 1;
                    }
                }

                index += 1;

            }

            return dictionary.Count == 0;
        }
    }
}
