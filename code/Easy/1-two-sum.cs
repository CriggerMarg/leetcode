namespace code
{
    public static partial class Easy
    {
        /// <summary>
        /// 1. Two Sum
        /// https://leetcode.com/problems/two-sum/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int a = 0; a < nums.Length - 1; a++)
                for (int b = a + 1; b < nums.Length; b++)
                {
                    if (nums[a] + nums[b] == target)
                        return new int[2] { a, b };
                }
            return new int[2] { 0, 1 };
        }
    }
}
