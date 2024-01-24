namespace LeapYear.Unit.Test._3;

public class YearService
{
    public bool IsLeap(uint year)
    {
        if (year % 400 == 0) return true;
        if (year % 100 == 0) return false;
        if (year % 4 == 0) return true;
        return false;
    }
}