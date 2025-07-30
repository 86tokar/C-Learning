using System;

    class Program
{
    static void Main()
    {

        int insertedNumber = GetIntInput("Enter integer number for task 1(check positive/negative/zero)");
        Task1.VerifyNumber(insertedNumber);

        int insertedNumberCase = GetIntInput("Enter integer number for task 1(check positive/negative/zero)");
        Task1SwitchCase.VerifyNumberCase(insertedNumberCase);

        int singleOrMoreDigits = GetIntInput("Enter integer number for task2(Check one digits ore more)");
        Task2.CalculateDigitsCount(singleOrMoreDigits);

        int insertedNumberTask3 = GetIntInput("Enter integer number for task3(Calculate a result)");
        Task3.CalculateResult(insertedNumberTask3);

        int programistAmount = GetIntInput("Enter integer number for task4(Build a correct string with programist)");
        Task4.BuildString(programistAmount);

        int firstNumber = GetIntInput("Enter integer number for task5(Compare numbers)");
        int secondNumber = GetIntInput("Enter integer number for task5(Compare numbers)");
        Task5.CompareNumbers(firstNumber, secondNumber);

        int side1 = GetIntInput("Enter integer number for task6(Check triangle)");
        int side2 = GetIntInput("Enter integer number for task6(Check triangle)");
        int side3 = GetIntInput("Enter integer number for task6(Check triangle)");
        Task6.IsTriangle(side1, side2, side3);

        int number1 = GetIntInput("Enter integer number for task7(Positive count)");
        int number2 = GetIntInput("Enter integer number for task7(Positive count)");
        int number3 = GetIntInput("Enter integer number for task7(Positive count)");
        Task7.CountPositive(number1, number2, number3);

        int number1_PN = GetIntInput("Enter integer number for task7(Positive/Negative count)");
        int number2_PN = GetIntInput("Enter integer number for task7(Positive/Negative count)");
        int number3_PN = GetIntInput("Enter integer number for task7(Positive/Negative count)");
        Task8.CountPositiveNegative(number1_PN, number2_PN, number3_PN);

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

    class Task1SwitchCase
    {
        public static void VerifyNumberCase(int insertedNumber)
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
                default:
                    Console.WriteLine("Other");
                    break;
            }
        }
    }

    class Task2
    {
        public static void CalculateDigitsCount(int singleOrMoreDigits)
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
    }

    class Task3
    {
        public static void CalculateResult(int insertedNumber)
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
    }

    class Task4
    {
        public static void BuildString(int programistAmount)
        {
            int lastDigit = programistAmount % 10;
            int lastTwoDigits = programistAmount % 100;

            if ((lastTwoDigits >= 11 && lastTwoDigits <= 14) ||
                lastDigit == 0 || lastDigit >= 5)
            {
                Console.WriteLine(programistAmount + " programistov");
            }
            else if (lastDigit == 1)
            {
                Console.WriteLine(programistAmount + " programist");
            }
            else
            {
                Console.WriteLine(programistAmount + " programista");
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
        public static void IsTriangle(int side1, int side2, int side3)
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
    }

    class Task7
    {
        public static void CountPositive(int number1, int number2, int number3)
        {
            int i = 0;
            if (number1 > 0) i++;
            if (number2 > 0) i++;
            if (number3 > 0) i++;
            Console.WriteLine(i);
        }
    }

    class Task8
    {
        public static void CountPositiveNegative(int number1, int number2, int number3)
        {
            int positive = 0;
            int negative = 0;

            if (number1 > 0) positive++;
            else if (number1 < 0) negative++;

            if (number2 > 0) positive++;
            else if (number2 < 0) negative++;

            if (number3 > 0) positive++;
            else if (number3 < 0) negative++;

            Console.WriteLine("Positive: " + positive);
            Console.WriteLine("Negative: " + negative);
        }
    }

