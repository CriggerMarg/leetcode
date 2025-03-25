using FluentAssertions;
using leetcode.BST;
using leetcode.tests.Helpers;

namespace leetcode.tests.BST;

public class _270_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				 [new int?[] { 4, 2, 5, 1, 3 }, 3.714286, 4],
				 [new int?[] { 4, 2, 5, 1, 3 }, 3.5, 3],
				 [new int?[] { 1, null, 2 },3.428571,2],
			];
	}

	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(int?[] tree, double val, int expected)
	{
		var test = new _270();
		var t = TreeHelper.BuildTreeFromLevelOrder(tree);
		var rez = test.ClosestValue(t, val);
		rez.Should().Be(expected);
	}
}
