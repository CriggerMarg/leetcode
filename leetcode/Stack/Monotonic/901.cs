namespace leetcode.Stack.Monotonic;

/// <summary>
/// https://leetcode.com/problems/online-stock-span/
/// </summary>
public class _901
{
    public class StockSpanner
    {
        private Stack<int[]> _stack = [];

        public int Next(int price)
        {
            int ans = 1;
            while (_stack.TryPeek(out var curr) && curr[0] <= price)
            {
                ans += _stack.Pop()[1];
            }
            _stack.Push([price, ans]);
            return ans;
        }
    }
}
