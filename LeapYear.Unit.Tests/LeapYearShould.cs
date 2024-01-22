using Xunit;

namespace LeapYear.Unit.Tests;

// Kata LeapYear
// Los a�os no divisibles por 4 no son bisiestos(como 1997).
// Los a�os divisibles por 4 son bisiestos(como 1996), excepto:
// Si son divisibles por 100 no son bisiestos(como 1900).
// Si son divisibles por 400 ser�n bisiestos(como 2000).

public class LeapYearShould
{
    [Fact]
    public void CanInstiantiate()
    {
        new Year();
    }
}
