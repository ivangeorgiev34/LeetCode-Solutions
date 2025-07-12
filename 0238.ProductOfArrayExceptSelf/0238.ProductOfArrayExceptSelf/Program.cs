namespace _0238.ProductOfArrayExceptSelf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public static int[] ProductExceptSelf(int[] nums)
        {
            var result = new int[nums.Length];

            var prefix = 1;
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = prefix;
                prefix *= nums[i];
            }

            var postfix = 1;
            for (int i = result.Length - 1; i >= 0; i--)
            {
                result[i] *= postfix;
                postfix *= nums[i];
            }

            return result;
        }

    }
}
