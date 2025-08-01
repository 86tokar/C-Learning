using System;

class Program
{
    static void Main()
    {

        int insertedNumber = GetIntInput("Enter integer number for task 1(check positive/negative/zero)");
        Task1.VerifyNumber(insertedNumber);

        Console.Write("Inter number as string");
        string singleOrMoreDigits = Console.ReadLine();
        Task2.CalculateDigitsCount(singleOrMoreDigits);

        int insertedNumberTask3 = GetIntInput("Enter integer number for task3(Calculate a result)");
        Task3.CalculateResult(insertedNumberTask3);

        int programistAmount = GetIntInput("Enter integer number for task4(Build a correct string with programist)");
        Task4.BuildString(programistAmount);

        int firstNumber = GetIntInput("Enter integer number for task5(Compare numbers)");
        int secondNumber = GetIntInput("Enter integer number for task5(Compare numbers)");
        Task5.CompareNumbers(firstNumber, secondNumber);


        int[] sides = new int[3];
        sides[0] = GetIntInput("Enter first side for task6 (Check triangle): ");
        sides[1] = GetIntInput("Enter second side for task6 (Check triangle): ");
        sides[2] = GetIntInput("Enter third side for task6 (Check triangle): ");
        Task6.IsTriangle(sides);


        int[] numbers = new int[3];
        numbers[0] = GetIntInput("Enter first number for task7 (Count positive): ");
        numbers[1] = GetIntInput("Enter second number for task7 (Count positive): ");
        numbers[2] = GetIntInput("Enter third number for task7 (Count positive): ");
        Task7.CountPositive(numbers);

        int[] numbers_PN = new int[3];
        numbers_PN[0] = GetIntInput("Enter integer number for task8 (Positive/Negative count): ");
        numbers_PN[1] = GetIntInput("Enter integer number for task8 (Positive/Negative count): ");
        numbers_PN[2] = GetIntInput("Enter integer number for task8 (Positive/Negative count): ");
        Task8.CountPositiveNegative(numbers_PN);

        static int GetIntInput(string prompt)
        {
            int result;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Incorrect input, please inter integer number");
                }
            }
        }



    }
}

class Task1
{
    public static void VerifyNumber(int insertedNumber)
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
}



class Task2
{

    public static void CalculateDigitsCount(string singleOrMoreDigits)
    {

        string resultNumber = singleOrMoreDigits.Replace("+", "").Replace("-", "").TrimStart('0');


        if (string.IsNullOrEmpty(resultNumber))
        {
            resultNumber = "0";
        }


        int digitCount = resultNumber.Length;

        if (digitCount == 1)
        {
            Console.WriteLine("Single");
        }
        else
        {
            Console.WriteLine("More");
        }

    }
}

class Task3
{
    public static void CalculateResult(int insertedNumber)
    {

        switch (insertedNumber)
        {
            case > 0:
                Console.WriteLine(insertedNumber + 1);
                break;
            case < 0:
                Console.WriteLine(insertedNumber - 2);
                break;
            default:
                Console.WriteLine(10);
                break;
        }
    }
}

class Task4
{
    public static void BuildString(int programistAmount)
    {
        switch (programistAmount % 10)
        {
            case var x when (x == 0 || (x >= 5 && x <= 9)):
                Console.WriteLine(programistAmount + " programistov");
                break;
            case 1:
                Console.WriteLine(programistAmount + " programist");
                break;
            default:
                Console.WriteLine(programistAmount + "programista");
                break;
        }


    }
}

class Task5
{
    public static void CompareNumbers(int firstNumber, int secondNumber)
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
}

class Task6
{
    public static void IsTriangle(int[] sides)
    {
        int side1 = sides[0];
        int side2 = sides[1];
        int side3 = sides[2];

        if ((side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1))
        {
            Console.WriteLine("Triangle");
        }
        else
        {
            Console.WriteLine("Not");
        }
    }
}

class Task7
{
    public static void CountPositive(int[] numbers)
    {
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0) count++;
        }
        Console.WriteLine(count);
    }
}

class Task8
{
    public static void CountPositiveNegative(int[] numbers)
    {
        int positive = 0;
        int negative = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0) positive++;
            else if (numbers[i] < 0) negative++;
        }

        Console.WriteLine("Positive: " + positive);
        Console.WriteLine("Negative: " + negative);
    }
}

