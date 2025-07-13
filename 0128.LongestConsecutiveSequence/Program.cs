namespace _0128.LongestConsecutiveSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LongestConsecutive(new int[] { 0 });
        }

        public static int LongestConsecutive(int[] nums)
        {
            var set = new HashSet<int>(nums);

            var longest = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i] - 1)) continue;

                var length = 0;
                while (set.Contains(length + nums[i]))
                {
                    length++;
                }

                if (length > longest) longest = length;
            }

            return longest;
        }
    }
}
