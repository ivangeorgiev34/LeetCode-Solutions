namespace _0228.SummaryRanges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SummaryRanges(new int[] { 0, 1, 2, 4, 5, 7 }));
        }

        public static IList<string> SummaryRanges(int[] nums)
        {
            var index = 0;
            var pointer = 0;
            var sets = new List<string>();

            while (index < nums.Length)
            {
                if (index < nums.Length - 1 && nums[index] + 1 == nums[index + 1])
                {
                    pointer = index;

                    while (pointer < nums.Length)
                    {
                        if (pointer < nums.Length - 1 && nums[pointer] + 1 == nums[pointer + 1])
                        {
                            pointer += 1;

                            continue;
                        }

                        break;
                    }

                    sets.Add($"{nums[index]}->{nums[pointer]}");
                    index = pointer;
                }
                else
                {
                    sets.Add($"{nums[index]}");
                }

                index += 1;
            }

            return sets;
        }
    }
}
