using leetcode.BinarySearch;
using FluentAssertions;

namespace leetcode.tests.BinarySearch;

public class _153_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				[new int[] { 4, 5, 6, 7, 0, 1, 2 },0],
				[new int[] { 3, 4, 5, 1, 2 },1],
				[new int[] { 11, 13, 15, 17 },11],
				[new int[] {1 },1],
				[new int[] {2,1 },1],
				[new int[] { 2, 3, 4, 5, 1 },1],
			];
	}
	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(int[] input, int expected)
	{
		var test = new _153();
		var rez = test.FindMin(input);
		rez.Should().Be(expected);
	}
}
