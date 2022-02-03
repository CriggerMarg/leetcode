namespace code
{
    public static partial class Easy
    {
        /// <summary>
        /// 1137. N-th Tribonacci Number
        /// https://leetcode.com/problems/n-th-tribonacci-number/
        /// </summary>
        public static int Tribonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 1;


            var dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = 1;
            dp[2] = 1;

            for (int i = 3; i < dp.Length; i++)
            {
                dp[i] = dp[i - 3] + dp[i - 2] + dp[i - 1];
            }

            return dp[dp.Length - 1];
        }
    }
}
