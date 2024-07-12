namespace _0049.GroupAnagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = GroupAnagrams(new string[] { "cab", "tin", "pew", "duh", "may", "ill", "buy", "bar", "max", "doc" });
            Console.WriteLine();
        }

        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dictionary = new Dictionary<string, IList<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                var charArr = strs[i].ToCharArray();
                Array.Sort(charArr);
                var keyString = new string(charArr);

                if (!dictionary.ContainsKey(keyString))
                {
                    dictionary.Add(keyString, new List<string>());
                }

                dictionary[keyString].Add(strs[i]);
            }

            return new List<IList<string>>(dictionary.Values);
        }
    }
}
