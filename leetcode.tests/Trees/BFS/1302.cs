using FluentAssertions;
using leetcode.tests.Helpers;
using leetcode.Trees.BFS;

namespace leetcode.tests.Trees.BFS;
public class _1302_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				 [new int?[] { 1, 2, 3, 4, 5, null, 6, 7, null, null, null, null, 8 },15],
				 [new int?[] { 6, 7, 8, 2, 7, 1, 3, 9, null, 1, 4, null, null, null, 5 },19],
			];
	}
	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(int?[] left, int expected)
	{
		var test = new _1302();
		var p = TreeHelper.BuildTreeFromLevelOrder(left);
		var rez = test.DeepestLeavesSum(p);
		rez.Should().Be(expected);
	}
}
