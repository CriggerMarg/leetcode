using FluentAssertions;
using leetcode.Stack;

namespace leetcode.tests.Stack;
public class _20_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				["()", true],
				["()[]{}", true],
				["(]", false],
				["([])", true],
			];
	}

	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(string input, bool expected)
	{
		var test = new _20();
		var isValid =test.IsValid(input);
		isValid.Should().Be(expected);
	}
}
