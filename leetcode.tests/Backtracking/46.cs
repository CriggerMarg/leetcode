using FluentAssertions;
using leetcode.Backtracking;

namespace leetcode.tests.Backtracking;

public class _46_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				[new int[] { 1, 2, 3 },new int[][] { [1, 2, 3], [1, 3, 2], [2, 1, 3], [2, 3, 1], [3, 1, 2], [3, 2, 1] }],
			];
	}

	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(int[] input, int[][] expected)
	{
		var test = new _46();
		var rez = test.Permute(input);
		rez.Should().BeEquivalentTo(expected);
	}
}
