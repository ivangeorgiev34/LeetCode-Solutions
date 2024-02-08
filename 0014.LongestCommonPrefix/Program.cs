namespace _0014.LongestCommonPrefix
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestCommonPrefix(["flower", "flow", "flight"]));
        }

        public static string LongestCommonPrefix(string[] strs)
        {

            var commonPrefix = strs[0];

            var lastIndexPrefix = -1;

            for (int i = 1; i < strs.Length; i++)
            {
                lastIndexPrefix = -1;

                for (int j = 0; j < strs[i].Length; j++)
                {
                    if (commonPrefix.Length == j)
                    {
                        break;
                    }

                    if (strs[i][j] == commonPrefix[j])
                    {
                        lastIndexPrefix += 1;
                    }
                    else
                    {
                        break;
                    }
                }

                commonPrefix = strs[i].Substring(0, lastIndexPrefix + 1);

            }

            return commonPrefix;
        }
    }
}
