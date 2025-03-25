namespace leetcode.Stack.Monotonic;
/// <summary>
/// https://leetcode.com/problems/final-prices-with-a-special-discount-in-a-shop/description/
/// </summary>
public class _1475
{
    public int[] FinalPrices(int[] prices)
    {
        var stack = new Stack<int>();
        int[] ans = new int[prices.Length];
        for (int i = prices.Length - 1; i >= 0; i--)
        {
            while (stack.TryPeek(out var curr) && prices[i] < curr)
            {
                stack.Pop();
            }
            ans[i] = stack.TryPeek(out var c) ? prices[i] - c : prices[i];
            stack.Push(prices[i]);
        }
        return ans;
    }
}
