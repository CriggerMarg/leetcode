namespace leetcode.SlidingWindow;

/// <summary>
/// https://leetcode.com/problems/find-the-k-beauty-of-a-number/
/// </summary>
public class _2269
{
    public int DivisorSubstrings(int num, int k)
    {
        int totalDigits = (int)Math.Floor(Math.Log10(num) + 1);
        int beautyCount = 0;
        int right = k;
        int left = 0;
        while (right <= totalDigits)
        {
            int truncatedNumber = num % (int)Math.Pow(10, totalDigits - left);
            int n = truncatedNumber / (int)Math.Pow(10, totalDigits - left - k);
            if (n != 0 && num % n == 0) beautyCount++;
            right++;
            left++;
        }
        return beautyCount;

    }

    public int DivisorSubstrings2(int num, int k)
    {
        int input = num;
        int length = (int)Math.Floor(Math.Log10(num) + 1); // Calculate the number of digits
        int[] digits = new int[length];

        for (int i = length - 1; i >= 0; i--)
        {
            digits[i] = num % 10; // Extract the last digit
            num /= 10;            // Remove the last digit
        }

        int beautyCount = 0;
        string numStr = num.ToString();
        int right = k;
        while (right <= digits.Length)
        {
            int n = 0;
            var power = (int)Math.Pow(10, k - 1);
            for (int left = right - k; left < right; left++)
            {
                n += digits[left] * power;
                power /= 10;
            }
            if (n != 0 && input % n == 0) beautyCount++;
            right++;
        }
        return beautyCount;
    }
}
