using FluentAssertions;
using Xunit;

namespace LeapYear.Unit.Tests._1;

//Kata LeapYears
//User Story: 
//As a user, I want to know if a year is a leap year,
//So that I can plan for an extra day on February 29th during those years.

//Acceptance Criteria:
//All years divisible by 400 ARE leap years(so, for example, 2000 was indeed a leap year),
//All years divisible by 100 but not by 400 are NOT leap years(so, for example, 1700, 1800, and 1900 were NOT leap years, NOR will 2100 be a leap year),
//All years divisible by 4 but not by 100 ARE leap years(e.g., 2008, 2012, 2016),
//All years not divisible by 4 are NOT leap years(e.g. 2017, 2018, 2019).

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
