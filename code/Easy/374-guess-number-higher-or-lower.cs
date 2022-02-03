namespace code
{
    public static partial class Easy
    {
        public class _374_guess_game
        {
            private readonly int _target;

            public _374_guess_game(int target)
            {
                _target = target;
            }

            /// <summary>
            /// 374. Guess Number Higher or Lower
            /// https://leetcode.com/problems/guess-number-higher-or-lower/
            /// </summary>
            public int GuessNumber(int n)
            {
                int l = 1;
                int r = n;
                if (n < 1)
                {
                    return n;
                }

                return BinarySearch(l, r, n);
            }


            private int BinarySearch(int l, int r, int x)
            {
                if (guess(l) == 0) return l;
                if (guess(r) == 0) return r;
                if (l == r)
                    return x;
                int mid = (int)System.Math.Ceiling((double)l + (r - l) / 2);
                if (guess(mid) == 0) return mid;

                if (guess(mid) == -1)
                    return BinarySearch(l, mid, x);
                else
                    return BinarySearch(mid + 1, r, x);

            }

            private int guess(int x)
            {
                if (_target == x)
                {
                    return 0;
                }
                if (_target < x)
                {
                    return -1;
                }
                return 1;
            }
        }
    }
}
