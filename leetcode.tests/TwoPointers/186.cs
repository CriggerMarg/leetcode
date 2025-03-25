using FluentAssertions;
using leetcode.TwoPointers;

namespace leetcode.tests.TwoPointers;
public class _186_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			new List<object[]>
			{
				new object[] { new char[] { 't', 'h', 'e', ' ', 's', 'k', 'y', ' ', 'i', 's', ' ', 'b', 'l', 'u', 'e' },
							   new char[] { 'b', 'l', 'u', 'e', ' ', 'i', 's', ' ', 's', 'k', 'y', ' ', 't', 'h', 'e' } },
				new object[] { new char[] { 'a' }, new char[] { 'a' } },
			};
	}

	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(char[] input, char[] expected)
	{
		var test = new _186();
		test.ReverseWords(input);
		for (int i = 0; i < input.Length; i++)
		{
			input[i].Should().Be(expected[i]);
		}
	}
}
