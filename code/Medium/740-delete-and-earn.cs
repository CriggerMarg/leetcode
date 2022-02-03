using System;

namespace code
{
    public static partial class Medium
    {
        /// <summary>
        /// 740. Delete and Earn
        /// https://leetcode.com/problems/delete-and-earn/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int DeleteAndEarn(int[] nums)
        {
            int[] points = new int[1 + 10000];

            foreach (int item in nums)
            {
                points[item] += item;
            }

            int maxTwoBefore = 0;
            int maxOneBefore = 0;
            for (int i = 0; i < points.Length; i++)
            {
                int maxCurr = Math.Max(maxTwoBefore + points[i], maxOneBefore);
                maxTwoBefore = maxOneBefore;
                maxOneBefore = maxCurr;
            }

            return maxOneBefore;
        }
    }
}
