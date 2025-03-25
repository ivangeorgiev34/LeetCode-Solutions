namespace _0271.EncodeAndDecodeStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = Encode(new List<string>() { "leet", "code" });
            var v = Decode(a);
        }

        private static string Encode(IList<string> strs)
        {
            var str = "";

            var pointer = 0;
            while (pointer < strs.Count)
            {
                str += strs[pointer].Length.ToString() + '#' + strs[pointer];

                pointer += 1;
            }

            return str;
        }

        private static List<string> Decode(string s)
        {
            var strings = new List<string>();

            var i = 0;

            while (i < s.Length)
            {
                var j = i;
                var length = "";

                while (s[j] != '#')
                {
                    length += s[j];

                    j += 1;
                }

                var word = "";
                var temp = j + 1;
                while (temp < j + 1 + int.Parse(length))
                {
                    word += s[temp];

                    temp += 1;
                }

                strings.Add(word);

                i = j + 1 + int.Parse(length);
            }

            return strings;
        }
    }
}
