namespace leetcode.Stack.Monotonic;
/// <summary>
/// https://leetcode.com/problems/next-greater-element-i/
/// </summary>
public class _496
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        Stack<int> stack = new();
        Dictionary<int, int> map = [];
        for (int i = 0; i < nums2.Length; i++)
        {
            while (stack.TryPeek(out var top) && top < nums2[i])
            {
                map[stack.Pop()] = nums2[i];
            }
            stack.Push(nums2[i]);
        }
        while (stack.Count > 0) map[stack.Pop()] = -1;
        int[] res = new int[nums1.Length];
        for (int i = 0; i < nums1.Length; i++)
        {
            res[i] = map[nums1[i]];
        }

        return res;
    }
}
