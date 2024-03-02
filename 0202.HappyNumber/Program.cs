namespace _0202.HappyNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsHappy(2));
        }

        public static bool IsHappy(int n)
        {
            if (n == 1)
            {
                return true;
            }
            var hashSet = new HashSet<int>();

            while (hashSet.Contains(n) == false)
            {
                if (n == 1)
                {
                    return true;
                }

                hashSet.Add(n);
                n = Calculate(n);
            }

            return false;
        }

        public static int Calculate(int n)
        {
            var result = 0;

            int currentNumber;
            while (n > 0)
            {
                currentNumber = n % 10;
                result += currentNumber * currentNumber;
                n /= 10;
            }

            return result;
        }
    }
}
