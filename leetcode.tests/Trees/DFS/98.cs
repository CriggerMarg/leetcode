using FluentAssertions;
using leetcode.tests.Helpers;
using leetcode.Trees.DFS;

namespace leetcode.tests.Trees.DFS;

public class _98_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				 [new int?[] { 2,  1, 3 }, true],
				 [new int?[] { 5, 1, 4, null, null, 3, 6 }, false],
				 [new int?[] { 5, 4, 6, null, null, 3, 7 }, false],
			];
	}
	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(int?[] left, bool expected)
	{
		var test = new _98();
		var p = TreeHelper.BuildTreeFromLevelOrder(left);
		var rez = test.IsValidBST(p);
		rez.Should().Be(expected);
	}
}
