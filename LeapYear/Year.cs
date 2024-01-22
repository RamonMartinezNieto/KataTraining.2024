namespace LeapYear;

public class Year(int year)
{
    public int Value { get; } = year;

    public bool IsLeap()
    {
        if (Value % 400 == 0) return true;
        if (Value % 100 == 0) return false;
        if (Value % 4 == 0) return true;
        return false;
    }
}