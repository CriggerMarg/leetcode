using System;

namespace code
{
    public static partial class Medium
    {
        /// <summary>
        /// 7. Reverse Integer
        /// https://leetcode.com/problems/reverse-integer/
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int Reverse(int x)
        {
            var rev = x.ToString().ToCharArray();
            Array.Reverse(rev);
            var rr = new string(rev);
            if (rr.EndsWith("-"))
            {
                rr = rr.Remove(rr.Length - 1);
                rr = rr.Insert(0, "-");
            }

            return int.TryParse(rr, out var rez) ? rez : 0;
        }
    }
}
