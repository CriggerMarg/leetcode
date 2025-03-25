namespace leetcode.TwoPointers;

public class _75
{
	/*
	[2,0,2,1,1,0]

	blue = 5
	red = 0

	1. 
		[0,0,2,1,1,2]
	    blue = 4
	    red = 1
	2. 
		[0,0,2,1,1,2]
	    blue = 4
	    red = 2
	3. 
		[0,0,1,1,2,2]
	    blue = 3
	    red = 2


	 */
	public void SortColors(int[] nums)
	{
		if (nums.Length < 2) return;
		int red = 0;
		int blue = nums.Length - 1;

		int idx = 0;
		while (idx <= blue)
		{
			if (nums[idx] == 2)
			{
				var tmp = nums[blue];
				nums[blue] = nums[idx];
				nums[idx] = tmp;
				blue--;
			}
			else if (nums[blue] == 0)
			{
				int tmp = nums[red];
				nums[red] = nums[idx];
				nums[idx] = tmp;
				idx++;
			}
			else
			{
				idx++;
			}
		}
	}
}
