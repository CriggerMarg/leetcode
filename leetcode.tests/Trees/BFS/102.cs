using FluentAssertions;
using leetcode.tests.Helpers;
using leetcode.Trees.BFS;

namespace leetcode.tests.Trees.BFS;

public class _102_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				 [new int?[] { 3, 9, 20, null, null, 15, 7 }, new List<IList<int>> { new List<int>() { 3 }, new List<int> { 9, 20 }, new List<int> { 15, 7 } }],
			];
	}
	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(int?[] input, IList<IList<int>> expected)
	{
		var test = new _102();
		var root = TreeHelper.BuildTreeFromLevelOrder(input);
		var rez = test.LevelOrder(root);
		rez.Should().BeEquivalentTo(expected);
	}

}
