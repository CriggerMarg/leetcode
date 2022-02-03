﻿using System;

namespace code
{
    public static partial class Medium
    {
        /// <summary>
        /// 198. House Robber
        /// https://leetcode.com/problems/house-robber/
        /// </summary>
        public static int Rob(int[] nums)
        {

            if (nums.Length == 1) return nums[0];

            if (nums.Length == 2) return Math.Max(nums[0], nums[1]);

            int[] dp = new int[nums.Length];

            // Base cases
            dp[0] = nums[0];
            dp[1] = Math.Max(nums[0], nums[1]);

            for (int i = 2; i < nums.Length; i++)
            {
                dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[i]);
            }

            return dp[nums.Length - 1];
        }
    }
}
