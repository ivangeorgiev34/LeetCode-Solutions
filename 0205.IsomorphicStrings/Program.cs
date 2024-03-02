namespace _0205.IsomorphicStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static bool IsIsomorphic(string s, string t)
        {
            var dictionary = new Dictionary<char, char>();
            var index = 0;

            while (index < s.Length)
            {
                if (dictionary.ContainsKey(s[index]) == false && dictionary.ContainsValue(t[index]) == false)
                {
                    dictionary.Add(s[index], t[index]);
                }
                else
                {
                    if (dictionary.ContainsKey(s[index]) == true)
                    {
                        if (dictionary[s[index]] != t[index])
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (dictionary.ContainsValue(t[index]) == true)
                        {
                            return false;
                        }
                    }
                }

                index += 1;
            }
            //b b
            //a a
            //c b
            //d a

            return true;
        }
    }
}
