using System;

namespace code
{
    public static partial class Easy
    {
        /// <summary>
        /// 746. Min Cost Climbing Stairs
        /// https://leetcode.com/problems/min-cost-climbing-stairs/
        /// </summary>
        public static int MinCostClimbingStairs(int[] cost)
        {
            if (cost.Length == 1) return cost[0];
            if (cost.Length == 2) return Math.Min(cost[0], cost[1]);

            int[] dp = new int[cost.Length + 1];
            dp[0] = 0;
            dp[1] = Math.Min(cost[0], cost[1]);

            for (int i = 2; i < dp.Length; i++)
            {
                dp[i] = cost[i - 1] + Math.Min(dp[i - 1], dp[i - 2]);
            }

            return Math.Min(dp[cost.Length], dp[cost.Length - 1]);
        }
    }
}
