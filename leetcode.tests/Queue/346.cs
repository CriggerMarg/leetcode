using FluentAssertions;
using leetcode.Queue;

namespace leetcode.tests.Queue;
public class _346Tests
{

    [Theory]
    [InlineData(3, new int[] { 1, 10, 3, 5 }, new double[] { 1, 5.5, 4.66667, 6 })]
    public void TestCases(int size, int[] values, double[] expected)
    {
        var tst = new _346.MovingAverage(size);
        for (int i = 0; i < values.Length; i++)
        {
            var rez = tst.Next(values[i]);
            rez.Should().BeApproximately(expected[i], 0.0001);
        }
    }
}
