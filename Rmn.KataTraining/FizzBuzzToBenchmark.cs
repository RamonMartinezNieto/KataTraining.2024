using BenchmarkDotNet.Attributes;
using System;

namespace Rmn.KataTraining;

public class FizzBuzzToBenchmark
{
    private static int ITEMS = 100;

    [Benchmark]
    public void FizzBuzzWithVariablesBool()
    {
        string[] items = new string[ITEMS];

        for (int i = 0; i < ITEMS; i++)
        {
            int number = i + 1;
            bool isMultipleByThree = (number % 3 == 0);
            bool isMultipleByFive = (number % 5 == 0);

            if (isMultipleByThree && isMultipleByFive) items[i] = "FizzBuzz";
            else if (isMultipleByThree) items[i] = "Fizz";
            else if (isMultipleByFive) items[i] = "Buzz";
            else items[i] = number.ToString();
        }
    }

    //winner
    [Benchmark]
    public void FizzBuzzWithoutVariablesBool()
    {
        string[] items = new string[ITEMS];

        for (int i = 0; i < ITEMS; i++)
        {
            int index = i + 1;

            if (index % 5 == 0 && index % 3 == 0) items[i] = "FizzBuzz";
            else if (index % 3 == 0) items[i] = "Fizz";
            else if (index % 5 == 0) items[i] = "Buzz";
            else items[i] = index.ToString();
        }
    }

    [Benchmark]
    public void FizzBuzzWithoutVariablesBoolWithoutIndex()
    {
        string[] items = new string[ITEMS];

        for (int i = 0; i < ITEMS; i++)
        {
            if (i + 1 % 5 == 0 && i + 1 % 3 == 0) items[i] = "FizzBuzz";
            else if (i + 1 % 3 == 0) items[i] = "Fizz";
            else if (i + 1 % 5 == 0) items[i] = "Buzz";
            else items[i] = (i + 1).ToString();
        }
    }

    [Benchmark]
    public void FizzBuzzWithoutVariablesBoolWithoutIndex_WithContinue()
    {
        string[] items = new string[ITEMS];

        for (int i = 0; i < ITEMS; i++)
        {
            if (i + 1 % 5 == 0 && i + 1 % 3 == 0)
            {
                items[i] = "FizzBuzz";
                continue;
            }

            if (i + 1 % 3 == 0)
            {
                items[i] = "Fizz";
                continue;
            }

            if (i + 1 % 5 == 0)
            {
                items[i] = "Buzz";
                continue;
            }

            items[i] = (i + 1).ToString();
        }
    }

    [Benchmark]
    public void FizzBuzzWithoutVariablesBoolWithoutIndex_WithContinue_WithParentesis()
    {
        string[] items = new string[ITEMS];

        for (int i = 0; i < ITEMS; i++)
        {
            if ((i + 1) % 5 == 0 && (i + 1) % 3 == 0)
            {
                items[i] = "FizzBuzz";
                continue;
            }

            if ((i + 1) % 3 == 0)
            {
                items[i] = "Fizz";
                continue;
            }

            if ((i + 1) % 5 == 0)
            {
                items[i] = "Buzz";
                continue;
            }

            items[i] = (i + 1).ToString();
        }
    }

    [Benchmark]
    public void FizzBuzzWithoutIndex_WithContinue_WithParentesis_FinalResult()
    {
        string[] items = new string[ITEMS];

        for (int i = 0; i < ITEMS; i++)
        {
            string result;
            bool isFizz = (i + 1) % 3 == 0;
            bool isBuzz = (i + 1) % 5 == 0;

            if (isFizz && isBuzz)
            {
                result = "FizzBuzz";
            }
            else if ((i + 1) % 3 == 0)
            {
                result = "Fizz";
            }
            else if ((i + 1) % 5 == 0)
            {
                result = "Buzz";
            }
            else
            {
                result = (i + 1).ToString();

            }

            items[i] = result;
        }
    }

    [Benchmark]
    public void FizzBuzzWithoutIndex_TernaryOperator()
    {
        string[] items = new string[ITEMS];

        for (int i = 0; i < ITEMS; i++)
        {
            bool isFizz = i + 1 % 3 == 0;
            bool isBuzz = i + 1 % 5 == 0;

            items[i] = isFizz && isBuzz
            ? "FizzBuzz"
            : isFizz
                ? "Fizz"
                : isBuzz
                    ? "Buzz"
                    : (i + 1).ToString();
        }
    }

    [Benchmark]
    public void FizzBuzz_SpanString()
    {
        Span<string> items = new string[ITEMS];

        for (int i = 0; i < ITEMS; i++)
        {
            if (i + 1 % 5 == 0 && i + 1 % 3 == 0)
            {
                items[i] = "FizzBuzz";
                continue;
            }

            if (i + 1 % 3 == 0)
            {
                items[i] = "Fizz";
                continue;
            }

            if (i + 1 % 5 == 0)
            {
                items[i] = "Buzz";
                continue;
            }

            items[i] = (i + 1).ToString();
        }
    }

}