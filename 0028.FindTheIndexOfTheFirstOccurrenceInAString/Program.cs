namespace _0028.FindTheIndexOfTheFirstOccurrenceInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int StrStr(string haystack, string needle)
        {
            var index = -1;

            var flag = false;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (needle[needle.Length - 1] == haystack[i])
                {

                    index = i;

                    for (int j = needle.Length - 1; j > 0; j++)
                    {
                        if (needle[j] == haystack[index])
                        {
                            flag = true;
                            index -= 1;
                        }
                        else
                        {
                            flag = false;
                            index = -1;
                            break;
                        }
                    }

                    if (flag)
                    {
                        return index;
                    }
                }
            }

            return index;
            //"sadbutsad" "sad"
        }
    }
}
