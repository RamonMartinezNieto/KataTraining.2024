namespace FizzBuzz._1;

public class FizzBuzzService
{
    private string[] _items;


    public FizzBuzzService(int size)
    {
        _items = new string[size];
    }

    public string[] GetItems()
    {
        for (int i = 0; i < 100; i++)
        {
            int number = i + 1;
            bool isMultipleByThree = (number % 3 == 0);
            bool isMultipleByFive = (number % 5 == 0);

            if (isMultipleByThree && isMultipleByFive) _items[i] = "FizzBuzz";
            else if (isMultipleByThree) _items[i] = "Fizz";
            else if (isMultipleByFive) _items[i] = "Buzz";
            else _items[i] = number.ToString();
        }

        return _items;
    }
}
