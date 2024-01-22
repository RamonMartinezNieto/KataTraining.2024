namespace LeapYear;

public class Year
{
    public int Value { get; }


    public Year(int year)
    {
        Value = year;
    }

    public bool IsLeap()
    {
        return false;
    }
}