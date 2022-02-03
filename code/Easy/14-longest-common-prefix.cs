namespace code
{
    public static partial class Easy
    {
        /// <summary>
        /// 14. Longest Common Prefix
        /// https://leetcode.com/problems/longest-common-prefix/
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public static string LongestCommonPrefix(string[] strs)
        {
            string output = "";
            int minLength = -1;
            foreach (var item in strs)
            {
                if (minLength == -1) minLength = item.Length;
                if (item.Length < minLength) minLength = item.Length;
            }

            for (int i = 0; i < minLength; i++)
            {
                string currChar = "";
                foreach (var str in strs)
                {
                    if (currChar == "") currChar = str.Substring(i, 1);
                    if (currChar != str.Substring(i, 1)) return output;
                }
                output += currChar;
            }
            return output;
        }
    }
}
