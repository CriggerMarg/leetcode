using FluentAssertions;
using leetcode.Heap;

namespace leetcode.tests.Heap;

public class _215_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				[new int[] { 3, 2, 1, 5, 6, 4 },2,5],
				[new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 },4,4],
		];
	}
	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(int[] input, int k, int expected)
	{
		var test = new _215();
		var rez = test.FindKthLargest(input, k);
		rez.Should().Be(expected);
	}
}
