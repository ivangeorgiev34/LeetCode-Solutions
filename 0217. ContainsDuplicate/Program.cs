namespace _0217._ContainsDuplicate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(ContainsDuplicate(new int[] { 1, 2, 3, 1 }));

        }

        public static bool ContainsDuplicate(int[] numbers)
        {
            var set = new HashSet<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (set.Contains(numbers[i]))
                {
                    return true;
                }

                set.Add(numbers[i]);
            }

            return false;
        }
    }
}
