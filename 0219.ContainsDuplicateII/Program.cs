namespace _0219.ContainsDuplicateII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContainsNearbyDuplicate(new int[] { 1, 0, 1, 1 }, 1));
        }

        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var dictionary = new Dictionary<int, int>();
            var index = 0;

            while (index < nums.Length)
            {
                if (dictionary.ContainsKey(nums[index]) == true)
                {
                    if (Math.Abs(dictionary[nums[index]] - index) <= k)
                    {
                        return true;
                    }

                    dictionary[nums[index]] = index;
                }
                else
                {
                    dictionary.Add(nums[index], index);
                }

                index += 1;
            }

            return false;
        }
    }
}
