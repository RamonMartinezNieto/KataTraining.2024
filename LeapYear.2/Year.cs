namespace LeapYear._2;


public class Year
{
    public uint Value { get; set; }

    public Year()
    {
        Value = (uint)DateTime.UtcNow.Year;
    }

    public Year(uint year)
    {
        Value = year;
    }

    public bool IsLeap()
    {
        if (Value % 400 == 0) { return true; }
        if (Value % 100 == 0) { return false; }
        if (Value % 4 == 0) { return true; }
        return false;
    }
}