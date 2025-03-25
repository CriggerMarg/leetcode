using FluentAssertions;
using leetcode.TwoPointers;

namespace leetcode.tests.TwoPointers;
public class _151_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				["the sky is blue", "blue is sky the"],
				["  hello world  ", "world hello"],
				["a good   example", "example good a"],
			];
	}

	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(string input, string expected)
	{
		var test = new _151();
		var rez = test.ReverseWords(input);
		rez.Should().Be(expected);
	}
}
