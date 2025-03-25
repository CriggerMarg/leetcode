namespace leetcode.Heap;
public class _215
{
	public int FindKthLargest(int[] nums, int k)
	{
		var heap = new PriorityQueue<int, int>();

		foreach (int i in nums)
		{
			heap.Enqueue(i, i);
			if (heap.Count > k)
				heap.Dequeue();
		}

		return heap.Dequeue();
	}
}
