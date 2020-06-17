using System;
using System.Linq;

namespace code
{
    public static class Hard
    {
        private static double ArrayMediana(int[] arr)
        {

            if (arr.Length % 2 == 1)
                return arr[arr.Length / 2];
            var left = arr[arr.Length / 2 - 1];
            var right = arr[arr.Length / 2];
            return 0.5 * (left + right);
        }

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var mrg = nums1.Concat(nums2).ToArray();
            Array.Sort(mrg);
            return ArrayMediana(mrg);
        }
    }
}
