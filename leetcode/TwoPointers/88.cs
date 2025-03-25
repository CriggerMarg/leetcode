namespace leetcode.TwoPointers;
/// <summary>
/// https://leetcode.com/problems/merge-sorted-array/description/
/// </summary>
public class _88
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int p = m + n - 1;
        int left = m - 1;
        int right = n - 1;
        while (left >= 0 && right >= 0)
        {
            if (nums1[left] > nums2[right])
            {
                nums1[p] = nums1[left];
                left--;
            }
            else
            {
                nums1[p] = nums2[right];
                right--;
            }
            p--;
        }
        while (right >= 0)
        {
            nums1[p] = nums2[right];
            right--;
            p--;
        }
    }

}
