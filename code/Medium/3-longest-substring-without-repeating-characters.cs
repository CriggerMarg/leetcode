namespace code
{
    public static partial class Medium
    {
        /// <summary>
        /// 3. Longest Substring Without Repeating Characters
        /// https://leetcode.com/problems/longest-substring-without-repeating-characters/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int LengthOfLongestSubstring(string s)
        {

            if (s == null || string.IsNullOrEmpty(s))
            {
                return 0;
            }
            int start = 0;

            var arr = new int[128];
            int index;
            int max = 0;
            int count = 0;
            var l = s.Length;
            for (int end = 0; end < l;)
            {
                index = s[end];
                if (arr[index] == 0)
                {
                    arr[index]++;
                    count++;
                    end++;
                }
                else
                {
                    arr[s[start++]]--;
                    count--;
                }

                if (count > max)
                {
                    max = count;
                }
            }

            return max;
        }

    }
}
