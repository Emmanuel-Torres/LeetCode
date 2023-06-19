using Problems.P1732;

namespace Problems.Tests.P1732;

public class P1732_Tests
{
    [Test]
    [TestCase(new int[] { -5, 1, 5, 0, -7 }, 1)]
    [TestCase(new int[] { -4, -3, -2, -1, 4, 3, 2 }, 0)]
    public void Tests(int[] inputs, int expected)
    {
        var sut = new P1732_Implementation();
        var res = sut.LargestAltitude(inputs);

        res.Should().Be(expected);
    }
}