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

// Calculate result

void calculateResult(int num)
{
    if (num > 0)
    {
        Console.WriteLine(num + 1);
    }
    else if (num < 0)
    {
        Console.WriteLine(num - 2);
    }
    else
    {
        Console.WriteLine(10);
    }
}

calculateResult(0);

// Build correct string
void buildString(int num)
{
    if (num % 10 == 0 || num % 10 == 5 || num % 10 == 6 || num % 10 == 7 || num % 10 == 8 || num % 10 == 9)
    {
        Console.WriteLine(num + " programistov");
    }
    else if (num % 10 == 1)
    {
        Console.WriteLine(num + " programist");
    }
    else 
    { 
        Console.WriteLine(num + " programista");
    }
}

buildString(14569);

// Equal or the biggest

void compareNumbers(int num1, int num2)
{
    if (num1 > num2)
    {
        Console.WriteLine(num1);
    }
    else if (num1 < num2)
    {
        Console.WriteLine(num2);
    }
    else
    {
        Console.WriteLine("Numbers are equal");
    }
}
compareNumbers(10, -10);
