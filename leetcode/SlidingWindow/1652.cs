namespace leetcode.SlidingWindow;
/// <summary>
/// https://leetcode.com/problems/defuse-the-bomb/
/// </summary>
public class _1652
{
    public int[] Decrypt(int[] code, int k)
    {
        int[] rez = new int[code.Length];

        if (k == 0) return rez;

        int curr = 0;
        if (k > 0)
        {
            int sum = 0;
            for (int i = 1; i <= k; i++)
            {
                var idx = (curr + i) % rez.Length;
                sum += code[idx];
            }
            rez[curr] = sum;
            curr++;
            while (curr < rez.Length)
            {
                sum -= code[curr % rez.Length];
                sum += code[(curr + k) % rez.Length];
                rez[curr] = sum;
                curr++;
            }
        }

        if (k < 0)
        {
            curr = rez.Length - 1;
            int sum = 0;
            for (int i = 1; i <= -k; i++)
            {
                var idx = (curr - i + rez.Length) % rez.Length;
                sum += code[idx];
            }
            rez[curr] = sum;
            curr--;
            while (curr >= 0)
            {
                sum -= code[curr % rez.Length];
                sum += code[(curr + k + rez.Length) % rez.Length];
                rez[curr] = sum;
                curr--;
            }
        }
        return rez;
    }


}
