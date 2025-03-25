namespace leetcode.Queue;
/// <summary>
/// https://leetcode.com/problems/moving-average-from-data-stream/
/// </summary>
public class _346
{
    public class MovingAverage(int size)
    {
        private Queue<int> q = new();

        public double Next(int val)
        {
            q.Enqueue(val);

            while (q.Count > size) q.Dequeue();

            return q.ToArray().Average();
        }
    }
}
