namespace leetcode.TwoPointers;

/// <summary>
/// https://leetcode.com/problems/reverse-string/
/// </summary>
public class _344
{
    public void ReverseString(char[] s)
    {
        int left = 0;
        int right = s.Length - 1;
        char temp;
        while (left < right)
        {
            temp = s[left];
            s[left] = s[right];
            s[right] = temp;
            left++;
            right--;
        }
    }
}
