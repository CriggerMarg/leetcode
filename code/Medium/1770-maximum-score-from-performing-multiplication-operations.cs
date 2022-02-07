using System;

namespace code
{
    public static partial class Medium
    {
        public static int MaximumScore(int[] nums, int[] multipliers)
        {
            return sum(nums, multipliers, 0, 0, new int[multipliers.Length, multipliers.Length]);
        }

        private static int sum(int[] nums, int[] multipliers, int i, int left, int[,] memo)
        {
            if (i == multipliers.Length)
            {
                return 0;
            }
            int mult = multipliers[i];
            int right = nums.Length - 1 - (i - left);

            if (memo[i, left] == 0)
            {
                memo[i, left] = Math.Max(mult * nums[left] + sum(nums, multipliers, i + 1, left + 1, memo),
                                         mult * nums[right] + sum(nums, multipliers, i + 1, left, memo));
            }
            return memo[i, left];
        }
    }
}
