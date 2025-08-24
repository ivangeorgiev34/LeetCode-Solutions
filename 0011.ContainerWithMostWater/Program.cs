namespace _0011.ContainerWithMostWater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));
        }
    }

    public class Solution
    {
        public int MaxArea(int[] height)
        {
            var left = 0;
            var right = height.Length - 1;

            var max = 0;

            while (left < right)
            {
                var curr = (right - left) * (height[left] < height[right] ? height[left] : height[right]);
                if (curr > max)
                {
                    max = curr;
                }

                if (height[left] > height[right]) right--;
                else left++;
            }

            return max;
        }
    }
}
