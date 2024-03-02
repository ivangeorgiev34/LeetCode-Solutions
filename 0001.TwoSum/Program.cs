namespace _0001.TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TwoSum(new int[] { 2, 7, 11, 15 }, 9));
        }
        public int[] TwoSum(int[] nums, int target)
        {
            var index = 0;
            var dictionary = new Dictionary<int, int>();
            var result = new int[2];

            while (index < nums.Length)
            {
                if (dictionary.ContainsKey(target - nums[index]) == true)
                {
                    result[0] = dictionary[target - nums[index]];
                    result[1] = index;

                    break;
                }

                dictionary[nums[index]] = index;

                index += 1;
            }

            return result;
        }
    }
}
