namespace _0121.BestTimeToBuyAndSellStock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();

            s.MaxProfit(new int[] { 1, 2 });
        }
    }

    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            var left = 0;
            var right = 1;

            var res = 0;

            while (right < prices.Length)
            {
                if (prices[right] < prices[left])
                {
                    left = right;
                }

                if (res < prices[right] - prices[left])
                {
                    res = prices[right] - prices[left];
                }

                right++;

            }

            return res;
        }
    }
}
