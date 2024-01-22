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
        if (Value % 400 == 0) return true;
        if (Value % 100 == 0) return false;
        if (Value % 4 == 0) return true;
        return false;
    }
}