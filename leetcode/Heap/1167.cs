namespace leetcode.Heap;

public class _1167
{
	public int ConnectSticks(int[] sticks)
	{
		var minHeap = new PriorityQueue<int, int>(sticks.Length);
		foreach (var n in sticks)
		{
			minHeap.Enqueue(n, n);

		}
		int totalCost = 0;
		while (minHeap.Count > 1)
		{
			var left = minHeap.Dequeue();
			var right = minHeap.Dequeue();
			var cost = left + right;
			totalCost += cost;
			minHeap.Enqueue(cost, 0);
		}
		return totalCost;
	}
}