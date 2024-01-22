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
        if (Value % 4 == 0)
        {
            if (Value % 100 == 0)
            {
                if (Value % 400 == 0)
                {
                    return true;
                }
                return false;
            }
            return true;
        }

        return false;
    }
}