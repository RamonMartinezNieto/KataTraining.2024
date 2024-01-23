using FizzBuzz._1;
using FluentAssertions;
using Xunit;

//Write a program that prints the numbers from 1 to 100. 
//But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”.
//For numbers which are multiples of both three and five print “FizzBuzz “.
//Stage 2 - new requirements

namespace FizzBuzz.Unit.Test._1;

public class FizBuzzShould
{
    [Fact]
    public void CanGetArrayOfString_WithTheNubmers()
    {
        FizzBuzzService sut = new(100);
        var result = sut.GetItems();

        result.Should().HaveCount(100);
        result.Should().HaveElementAt(0, "1");
        result.Should().HaveElementAt(97, "98");
    }

    [Fact]
    public void NumbersMulitpleOfThree_ReturnFizz()
    {
        FizzBuzzService sut = new(100);
        var result = sut.GetItems();

        result.Should().HaveElementAt(2, "Fizz");
        result.Should().HaveElementAt(5, "Fizz");
        result.Should().HaveElementAt(8, "Fizz");
    }

    [Fact]
    public void NumbersMulitpleOfFive_ReturnBuzz()
    {
        FizzBuzzService sut = new(100);
        var result = sut.GetItems();

        result.Should().HaveElementAt(4, "Buzz");
        result.Should().HaveElementAt(9, "Buzz");
    }

    [Fact]
    public void NumbersMulitpleOfFiveAndThree_ReturnFizzBuzz()
    {
        FizzBuzzService sut = new(100);
        var result = sut.GetItems();

        result.Should().HaveElementAt(14, "FizzBuzz");
    }

}
