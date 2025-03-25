namespace leetcode.Heap;

public class _1962
{
	public int MinStoneSum(int[] piles, int k)
	{
		var maxHeap = new PriorityQueue<int, int>(piles.Length, Comparer<int>.Create((a, b) => b.CompareTo(a)));

		foreach (var pile in piles)
		{
			maxHeap.Enqueue(pile, pile);
		}
		for (int i = 0; i < k; i++)
		{
			var remove = maxHeap.Dequeue();
			var curr = remove / 2;
			maxHeap.Enqueue(remove - curr, remove - curr);
		}
		int sum = 0;
		while (maxHeap.TryDequeue(out var el, out _))
		{
			sum += el;
		}
		return sum;
	}
}
