using Problems.P1396;

namespace Problems.Tests;

public class P1396_Tests
{
    [Test]
    public void Scenario1()
    {
        var sut = new P1396_Implementation();
        sut.CheckIn(45, "Leyton", 3);
        sut.CheckIn(32, "Paradise", 8);
        sut.CheckIn(27, "Leyton", 10);
        sut.CheckOut(45, "Waterloo", 15);  // Customer 45 "Leyton" -> "Waterloo" in 15-3 = 12
        sut.CheckOut(27, "Waterloo", 20);  // Customer 27 "Leyton" -> "Waterloo" in 20-10 = 10
        sut.CheckOut(32, "Cambridge", 22); // Customer 32 "Paradise" -> "Cambridge" in 22-8 = 14

        sut.GetAverageTime("Paradise", "Cambridge").Should().Be(14);
        sut.GetAverageTime("Leyton", "Waterloo").Should().Be(11);

        sut.CheckIn(10, "Leyton", 24);
        sut.GetAverageTime("Leyton", "Waterloo").Should().Be(11); // return 11.00000

        sut.CheckOut(10, "Waterloo", 38);  // Customer 10 "Leyton" -> "Waterloo" in 38-24 = 14
        sut.GetAverageTime("Leyton", "Waterloo").Should().Be(12);
    }

    // [Test]
    // public void Scenario2()
    // {
    //     var sut = new P1396_Implementation();
    //     sut.CheckIn(10, "Leyton", 3);
    //     sut.CheckOut(10, "Paradise", 8); // Customer 10 "Leyton" -> "Paradise" in 8-3 = 5
    //     sut.GetAverageTime("Leyton", "Paradise").Should().Be(5); // return 5.00000, (5) / 1 = 5
    //     sut.CheckIn(5, "Leyton", 10);
    //     sut.CheckOut(5, "Paradise", 16); // Customer 5 "Leyton" -> "Paradise" in 16-10 = 6
    //     sut.GetAverageTime("Leyton", "Paradise").Should().Be(5.50000); // return 5.50000, (5 + 6) / 2 = 5.5
    //     sut.CheckIn(2, "Leyton", 21);
    //     sut.CheckOut(2, "Paradise", 30); // Customer 2 "Leyton" -> "Paradise" in 30-21 = 9
    //     sut.GetAverageTime("Leyton", "Paradise").Should().Be(6.66667); // return 6.66667, (5 + 6 + 9) / 3 = 6.66667
    // }
}