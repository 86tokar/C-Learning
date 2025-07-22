using System;

// Verify an inputted number (positive, negative, zero);
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

// Calculate digits count;

void calculateCount(int num)
{
    if (num < 10 && num > -10)
    {
        Console.WriteLine("Single");
    
    }
    else
    {
        Console.WriteLine("More");
    }
}
calculateCount(0);

