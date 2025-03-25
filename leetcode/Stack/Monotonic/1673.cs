namespace leetcode.Stack.Monotonic;

/// <summary>
/// https://leetcode.com/problems/find-the-most-competitive-subsequence/
/// </summary>
public class _1673
{
    public int[] MostCompetitive(int[] nums, int k)
    {
        var stack = new Stack<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int r = nums.Length - i + stack.Count;
            while (r >= k && stack.TryPeek(out var curr) && nums[i] < curr)
            {
                stack.Pop();
            }
            if (stack.Count < k)
                stack.Push(nums[i]);
        }
        int[] arr = new int[k];
        while (stack.Count > k) stack.Pop();
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            arr[i] = stack.Pop();
        }
        return arr;
    }
}
