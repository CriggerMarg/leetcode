using FluentAssertions;
using leetcode.TwoPointers;

namespace leetcode.tests.TwoPointers;

public class _344_ReverseStringTests
{

	[Theory]
	[InlineData(new char[] { 'h', 'e', 'l', 'l', 'o' }, new char[] { 'o', 'l', 'l', 'e', 'h' })]
	[InlineData(new char[] { 'H', 'a', 'n', 'n', 'a', 'h' }, new char[] { 'h', 'a', 'n', 'n', 'a', 'H' })]
	public void Should_ReverseString(char[] input, char[] output)
	{
		var r = new _344();
		r.ReverseString(input);
		output.Should().Equal(input);
	}
}
