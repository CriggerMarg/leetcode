using FluentAssertions;
using leetcode.TwoPointers;

namespace leetcode.tests.TwoPointers;
public class _42_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
					[new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 },6],
					[new int[] { 4, 2, 0, 3, 2, 5 },9],
			];
	}

	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(int[] input, int expected)
	{
		var test = new _42();
		var rez = test.Trap(input);
		rez.Should().Be(expected);
	}
}
