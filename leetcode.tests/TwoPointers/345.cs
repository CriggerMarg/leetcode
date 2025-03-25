using FluentAssertions;
using leetcode.TwoPointers;

namespace leetcode.tests.TwoPointers;
public class _345_ReverseVowelsofaStringTests
{
    [Theory]
    [InlineData("IceCreAm", "AceCreIm")]
    [InlineData("leetcode", "leotcede")]
    public void TestCases(string input, string output)
    {
        var test = new _345();
        var rez = test.ReverseVowels(input);
        rez.Should().Be(output);
    }
}
