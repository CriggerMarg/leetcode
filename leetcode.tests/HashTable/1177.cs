using FluentAssertions;
using leetcode.HashTable;

namespace leetcode.tests.HashTable;

public class _1177_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				["abcda", new int[][] { [3, 3, 0], [1, 2, 0], [0, 3, 1], [0, 3, 2], [0, 4, 1] }, new List<bool> { true, false, false, true, true }],
			//	["lyb", new int[][] { [0, 1, 0], [2, 2, 1] }, new List<bool> { false, true }],
			//	["hunu", new int[][] { [1, 1, 1], [2, 3, 0], [3, 3, 1], [0, 3, 2], [1, 3, 3], [2, 3, 1], [3, 3, 1], [0, 3, 0], [1, 1, 1], [2, 3, 0], [3, 3, 1], [0, 3, 1], [1, 1, 1] }, new List<bool> { true, false, true, true, true, true, true, false, true, false, true, true, true }],
			//	["hunu", new int[][] { [0, 3, 1]}, new List<bool> {  true}],
			];
	}

	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(string input, int[][] queries, IList<bool> expected)
	{
		var test = new _1177();
		var rez = test.CanMakePaliQueries(input, queries);
		rez.Should().BeEquivalentTo(expected);
	}
}
