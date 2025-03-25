using FluentAssertions;
using leetcode.TwoPointers;

namespace leetcode.tests.TwoPointers;
public class _5_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				["babad","bab"],
				["cbbd", "bb"],
			];
	}

	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(string input, string expected)
	{
		var test = new _5();
		var isValid = test.LongestPalindrome(input);
		isValid.Should().Be(expected);
	}
}
