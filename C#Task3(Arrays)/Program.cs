using System;

class Program
{
    static void Main()
    {

        int[] positiveNumbers = GetPositiveArrayFromKeyboard();
        Task1.VerifyAscArray(positiveNumbers);

        int[] positiveNumbersInArrayWithRange = GetPositiveArrayWithRangeCheck();
        Task2.GetMaximumNumberInArray(positiveNumbersInArrayWithRange);




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

        static int GetPositiveIntInput(string prompt)
        {
            int result;
            while (true)
            {
                result = GetIntInput(prompt);
                if (result > 0)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Incorrect input, enter positive integer number please");
                }
            }
        }

        static int[] GetPositiveArrayFromKeyboard()
        {
            Console.Write("Enter amount of elements in the array: ");
            int amount = GetPositiveIntInput("");

            int[] array = new int[amount];

            for (int i = 0; i < amount; i++)
            {
                array[i] = GetPositiveIntInput($"Enter element {i + 1}: ");
            }

            return array;
        }

        static int[] GetPositiveArrayWithRangeCheck()
        {
            int amount = GetPositiveIntInput("Enter amount of elements in the array: ");
            int[] array = new int[amount];

            for (int i = 0; i < amount; i++)
            {
                int value = GetIntInput("Enter element(0–16)");

                if (value < 0 || value > 16)
                {
                    Console.WriteLine("Element is out of range (0–16). Please enter again.");
                    i--; 
                }
                else
                {
                    array[i] = value;
                }
            }

            return array;
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();



    }
}

class Task1
{
    public static void VerifyAscArray(int[] positiveNumbers)
    {
        for (int i = 0; i < positiveNumbers.Length - 1; i++)
        {
            if (positiveNumbers[i] >= positiveNumbers[i + 1])
            {
                Console.WriteLine("No");
                return;
            }
        }

        Console.WriteLine("Yes");
    }
}

class Task2
{
    public static void GetMaximumNumberInArray(int[] positiveNumbers)
    {
        int maxNumber = positiveNumbers.Max();

        Console.WriteLine(maxNumber);
    }
}



