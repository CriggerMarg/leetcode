namespace code
{
    public static partial class Easy
    {
        public class _278_first_bad_version
        {
            private readonly int _firstBad;

            public _278_first_bad_version(int firstBad)
            {
                _firstBad = firstBad;
            }

            /// <summary>
            /// 278. First Bad Version
            /// https://leetcode.com/problems/first-bad-version/
            /// </summary>
            public int FirstBadVersion(int n)
            {
                int l = 1;
                int r = n;
                if (n < 1)
                {
                    return n;
                }

                return BinarySearch(l, r);
            }

            private int BinarySearch(int l, int r)
            {
                if (l == r)
                    return r;
                int mid = l + (r - l) / 2;
                if (IsBadVersion(mid))
                    return BinarySearch(l, mid);
                else
                    return BinarySearch(mid + 1, r);

            }
            private bool IsBadVersion(int n)
            {
                return n >= _firstBad;
            }
        }
    }
}
