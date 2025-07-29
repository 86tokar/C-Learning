using System;

// Verify an inputted number (positive, negative, zero);

void VerifyNumber(int insertedNumber)
{
    if (insertedNumber < 0)
    {
        Console.WriteLine("Negative");
    }
    else if (insertedNumber == 0)
    {
        Console.WriteLine("Zero");
    }
    else
    {
        Console.WriteLine("Positive");
    }
}
VerifyNumber(3);

void VerifyNumberCase(int insertedNumber)
{
    switch (insertedNumber)
    {
        case -1:
            Console.WriteLine("Negative");
            break;
        case 0:
            Console.WriteLine("Zero");
            break;
        case 1:
            Console.WriteLine("Positive");
            break;
    }
}


VerifyNumberCase(0);

// Calculate digits count;

void CalculateCount(int singleOrMoreDigits)
{
    if (singleOrMoreDigits < 10 && singleOrMoreDigits > -10)
    {
        Console.WriteLine("Single");
    }
    else
    {
        Console.WriteLine("More");
    }
}
CalculateCount(0);

// Calculate result

void CalculateResult(int insertedNumber)
{
    if (insertedNumber > 0)
    {
        Console.WriteLine(insertedNumber + 1);
    }
    else if (insertedNumber < 0)
    {
        Console.WriteLine(insertedNumber - 2);
    }
    else
    {
        Console.WriteLine(10);
    }
}

CalculateResult(0);

// Build correct string
void BuildString(int programistAmount)
{
    if (programistAmount % 10 == 0 || programistAmount % 10 == 5 || programistAmount % 10 == 6 || programistAmount % 10 == 7 || programistAmount % 10 == 8 || programistAmount % 10 == 9)
    {
        Console.WriteLine(programistAmount + " programistov");
    }
    else if (programistAmount % 10 == 1)
    {
        Console.WriteLine(programistAmount + " programist");
    }
    else 
    { 
        Console.WriteLine(programistAmount + " programista");
    }
}

BuildString(14569);

// Equal or the biggest

void CompareNumbers(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber)
    {
        Console.WriteLine(firstNumber);
    }
    else if (firstNumber < secondNumber)
    {
        Console.WriteLine(secondNumber);
    }
    else
    {
        Console.WriteLine("Numbers are equal");
    }
}
CompareNumbers(10, -10);

// isTriangle
void IsTriangle(int side1, int side2, int side3)
{
    if ((side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1))
    {
        Console.WriteLine("Triangle");
    }
    else
    {
        Console.WriteLine("Not");
    }
}
IsTriangle(1,2,3);

// Count Positive numbers
void CountPositive(int number1, int number2, int number3)
{
    int i = 0;
        
    if (number1 > 0)
    {
        i = i + 1;
    }
    if (number2 > 0)
    {
        i = i + 1;
    }
    if (number3 > 0)
    {
        i = i + 1;
    }
    Console.WriteLine(i);
}
CountPositive(1, -1, -1);

// Count Positive and Negative numbers
void CountPositiveNegative(int number1, int number2, int number3)
{
    int i = 0;
    int j = 0;

    if (number1 > 0)
    {
        i = i + 1;
    }
    else if (number2 < 0)
    {
        j = j + 1;
    }
    if (number3 > 0)
    {
        i = i + 1;
    }
    else if (number2 < 0)
    {
        j = j + 1;
    }
    if (number3 > 0)
    {
        i = i + 1;
    }
    else if (number3 < 0)
    {
        j = j + 1;
    }
    Console.WriteLine("Positive:" + i);
    Console.WriteLine("Negative:" + j);
}
CountPositiveNegative(1, -1, -1);
