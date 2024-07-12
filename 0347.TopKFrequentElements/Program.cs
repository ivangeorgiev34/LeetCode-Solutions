namespace _0347.TopKFrequentElements
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = TopKFrequent(new int[] { 1, 1, 1, 3, 2, 2 }, 2);
            Console.WriteLine();
        }

        public static int[] TopKFrequent(int[] nums, int k)
        {
            var frequentElements = new List<int>();

            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], 0);
                }

                dict[nums[i]] += 1;
            }

            var sortedDictionaryValues = dict.OrderByDescending(x => x.Value).ToArray();

            for (int i = 0; i < k; i++)
            {
                frequentElements.Add(sortedDictionaryValues[i].Key);
            }

            return frequentElements.ToArray();
        }
    }
}
