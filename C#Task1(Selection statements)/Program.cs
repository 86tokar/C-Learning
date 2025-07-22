using System;

void verifyNumber(int num)
{
    if (num < 0)
    {
        Console.WriteLine("Negative");
    }
    else if (num == 0)
    {
        Console.WriteLine("Zero");
    }
    else
    {
        Console.WriteLine("Positive");
    }
}
verifyNumber(3);
