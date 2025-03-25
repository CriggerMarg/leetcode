using FluentAssertions;
using leetcode.TwoPointers;

namespace leetcode.tests.TwoPointers;

public class _283_MoveZeroesTests
{
	[Theory]
	[InlineData(new int[] { 0, 1, 0, 3, 12 }, new int[] { 1, 3, 12, 0, 0 })]
	public void TestCases(int[] input, int[] output)
	{
		var test = new _283();
		test.MoveZeroes(input);
		input.Should().Equal(output);
	}
}
