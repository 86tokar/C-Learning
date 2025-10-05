using System;

class Program
{
    static void Main()
    {
        int hours = GetIntInput("Enter amount of hours for Task1 ");
        Task1.CalculateDistance(hours);
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

class Task1
{
    public static void CalculateDistance(int hours)
    {
        int firstHourKm = 10;
        double currentDistance = firstHourKm;
        double totalDistance = firstHourKm;
        for (int h = 2; h <= hours; h++)
        {
            currentDistance = currentDistance * 1.1;
            totalDistance = totalDistance + currentDistance;
        }
        Console.WriteLine(totalDistance);
    }
        
}