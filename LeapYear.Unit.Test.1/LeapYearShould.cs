using FluentAssertions;
using LeapYear._2;
using Xunit;

//Kata LeapYears
//User Story: 
//As a user, I want to know if a year is a leap year,
//So that I can plan for an extra day on February 29th during those years.

//Acceptance Criteria:
//All years divisible by 400 ARE leap years(so, for example, 2000 was indeed a leap year),
//All years divisible by 100 but not by 400 are NOT leap years(so, for example, 1700, 1800, and 1900 were NOT leap years, NOR will 2100 be a leap year),
//All years divisible by 4 but not by 100 ARE leap years(e.g., 2008, 2012, 2016),
//All years not divisible by 4 are NOT leap years(e.g. 2017, 2018, 2019).


namespace LeapYear.Unit.Tests._2;

public class LeapYearShould
{
    [Fact]
    public void CanGetYear()
    {
        Year year = new(1999);
        year.Value.Should().Be(1999);
    }

    [Fact]
    public void CanSetCurrentYear_WhenUseDefaultConstructor()
    {
        Year year = new();
        year.Value.Should().Be(2024);
    }

    [Fact]
    public void ReturnTrue_WhenIsDivisibleBy400()
    {
        Year year = new(400);
        var result = year.IsLeap();
        result.Should().BeTrue();
    }

    [Fact]
    public void ReturnFalse_When_IsDivisibleBy100ButNotby400()
    {
        Year year = new(100);
        var result = year.IsLeap();
        result.Should().BeFalse();
    }

    [Fact]
    public void ReturnTrue_WhenIsDivisibleBy4ButNotBy100()
    {
        Year year = new(4);
        var result = year.IsLeap();
        result.Should().BeTrue();
    }

    [Fact]
    public void ReturnFalse_WhenIsNotDivisibleBy4()
    {
        Year year = new(6);
        var result = year.IsLeap();
        result.Should().BeFalse();
    }
}