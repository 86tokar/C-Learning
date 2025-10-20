using System;
namespace C_Task2_Iteration_statements_
{
    class Program
    {
        static void Main()
        {
            int hoursDistance = GetIntInput("Enter amount of hours for Task1 ");
            Task1.CalculateDistance(hoursDistance);

            int hoursAmeba = GetIntInput("Enter amount of hours for Task2 ");
            Task2.CalculateAmeba(hoursAmeba);

            int amountOfElementsInArray = GetIntInput("Enter amount of array elements for Task3 ");
            Task3.CalculatePositiveArray(amountOfElementsInArray);

            int firstNum = GetIntInput("Enter first integer value ");
            int secondNum = GetIntInput("Enter second integer value ");
            Task4.MultNum(firstNum, secondNum);

            Task5.InchToCm();

            Task6.EvenNum();

            Task7.OddNum();

            Task8.ShowTriangles();
            Console.ReadLine();

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
}



