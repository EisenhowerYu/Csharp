using MyLibrary;

namespace TestProject1;

public class WeatherCalculatorTests
{
    [Theory]
    [InlineData(3, "Spring")]
    [InlineData(4, "Spring")]
    [InlineData(5, "Spring")]
    [InlineData(6, "Summer")]
    [InlineData(7, "Summer")]
    [InlineData(8, "Summer")]
    [InlineData(9, "Autumn")]
    [InlineData(10, "Autumn")]
    [InlineData(11, "Autumn")]
    [InlineData(12, "Winter")]
    [InlineData(1, "Winter")]
    [InlineData(2, "Winter")]

    public void DetermineSeason_ReturnCorrectSeasonForGivenMonth(int month, string expectedSeason) {
        var date = new DateOnly(2024, month, 1);
        Assert.Equal(expectedSeason, WeatherCalculator.DetermineSeason(date));
    }

    [Fact]
    public void DetermineSeason_ReturnWinterForLeapYearFebruary() {
        Assert.Equal("Winter", WeatherCalculator.DetermineSeason(new DateOnly(2024, 2, 29)));
    }
}