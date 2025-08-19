namespace _0015._3Sum
{
    public class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            solution.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });
        }
    }

    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var res = new List<IList<int>>();

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                var left = i + 1;
                var right = nums.Length - 1;

                while (left < right)
                {
                    var threeSum = nums[i] + nums[left] + nums[right];

                    if (threeSum > 0) right--;
                    else if (threeSum < 0) left++;
                    else
                    {
                        res.Add(new List<int>() { nums[i], nums[left], nums[right] });
                        left++;
                        while (nums[left] == nums[left - 1] && left < right) left++;
                    }
                }
            }

            return res;
        }
    }
}
