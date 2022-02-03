namespace code
{
    public static partial class Easy
    {
        /// <summary>
        /// 9. Palindrome Number
        /// https://leetcode.com/problems/palindrome-number/
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            var s = x.ToString();
            var l = s.Length;
            for (int i = 0; i < l - 1; i++)
                for (int j = l - 1; j > 0; j--)
                {
                    if (s[i] != s[j])
                    {
                        return false;
                    }

                    i++;
                }

            return true;

        }
    }
}
