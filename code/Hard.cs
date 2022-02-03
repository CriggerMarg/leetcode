using System;
using System.Linq;

namespace code
{
    public static class Hard
    {
        /// <summary>
        /// 4. Median of Two Sorted Arrays
        /// https://leetcode.com/problems/median-of-two-sorted-arrays/
        /// </summary>
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var mrg = nums1.Concat(nums2).ToArray();
            Array.Sort(mrg);

            if (mrg.Length % 2 == 1)
                return mrg[mrg.Length / 2];
            var left = mrg[mrg.Length / 2 - 1];
            var right = mrg[mrg.Length / 2];
            return 0.5 * (left + right);
        }
    }
}
