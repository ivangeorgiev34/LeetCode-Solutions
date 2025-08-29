namespace _0042.TrappingRainWater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }));
        }
    }

    public class Solution
    {
        public int Trap(int[] height)
        {
            var leftMax = new int[height.Length];
            var left = 0;

            var rightMax = new int[height.Length];
            var right = 0;

            for (int i = 0; i < height.Length; i++)
            {
                leftMax[i] = left;
                left = Math.Max(left, height[i]);

                rightMax[height.Length - 1 - i] = right;
                right = Math.Max(right, height[height.Length - 1 - i]);
            }

            var sum = 0;

            for (int i = 0; i < height.Length; i++)
            {
                var res = Math.Min(leftMax[i], rightMax[i]) - height[i];
                sum += Math.Max(0, res);
            }

            return sum;
        }
    }
}
