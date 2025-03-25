using FluentAssertions;
using leetcode.BinarySearch;

namespace leetcode.tests.BinarySearch;

public class _35_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				[new int[] { 1, 3, 5, 6 },5, 2],
				[new int[] { 1, 3, 5, 6 },2, 1],
				[new int[] { 1, 3, 5, 6 },7, 4],
			];
	}
	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(int[] input, int target, int expected)
	{
		var test = new _35();
		var rez = test.SearchInsert(input, target);
		rez.Should().Be(expected);
	}
}
