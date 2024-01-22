using FluentAssertions;
using Xunit;

namespace LeapYear.Unit.Tests;

// Kata LeapYear
// Los años no divisibles por 4 no son bisiestos(como 1997).
// Los años divisibles por 4 son bisiestos(como 1996), excepto:
// Si son divisibles por 100 no son bisiestos(como 1900).
// Si son divisibles por 400 serán bisiestos(como 2000).

public class LeapYearShould
{
    [Theory]
    [InlineData(2017)]
    [InlineData(2018)]
    [InlineData(2019)]
    public void ReturnFalse_WhenIsNotDivisibleBy4(int year)
    {
        var sut = new Year(year);
        var result = sut.IsLeap();
        result.Should().BeFalse();
    }

    [Theory]
    [InlineData(2008)]
    [InlineData(2012)]
    [InlineData(2016)]
    public void ReturnTrue_WhenIsDivisibleBy4(int year)
    {
        var sut = new Year(year);
        var result = sut.IsLeap();
        result.Should().BeTrue();
    }

    [Theory]
    [InlineData(2100)]
    [InlineData(1000)]
    [InlineData(300)]
    [InlineData(200)]
    [InlineData(100)]
    public void ReturnFalse_WhenIsDivisibleBy4_And_IsNotDivisibleBy100(int year)
    {
        var sut = new Year(year);
        var result = sut.IsLeap();
        result.Should().BeFalse();
    }

    [Theory]
    [InlineData(2400)]
    [InlineData(2000)]
    [InlineData(800)]
    [InlineData(400)]
    public void ReturnTrue_WhenIsDivisibleBy4_And_IsDivisibleBy400(int year)
    {
        var sut = new Year(year);
        var result = sut.IsLeap();
        result.Should().BeTrue();
    }
}
