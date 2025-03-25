namespace leetcode.TwoPointers;
/// <summary>
/// https://leetcode.com/problems/reverse-vowels-of-a-string/
/// </summary>
public class _345
{
    public string ReverseVowels(string s)
    {
        HashSet<char> vowels =
        [
            'a', 'e', 'i', 'o', 'u','A','E','I','O','U'
        ];
        char[] ss = s.ToCharArray();
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            while (left < right && !vowels.Contains(ss[left])) left++;
            while (left < right && !vowels.Contains(ss[right])) right--;

            char tmp = ss[left];
            ss[left] = ss[right];
            ss[right] = tmp;
            left++;
            right--;
        }
        return new string(ss);
    }
}
