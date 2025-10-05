using System;

class Program
{
    static void Main()
    {
        int hoursDistance = GetIntInput("Enter amount of hours for Task1 ");
        Task1.CalculateDistance(hoursDistance);
        

        int hoursAmeba = GetIntInput("Enter amount of hours for Task2 ");
        Task2.CalculateAmeba(hoursAmeba);
        Console.ReadKey();

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


class Task2
{
    public static void CalculateAmeba(int hours)
    {
        int amebaAmount = 1;
        int timeStep = 3;
        int currentTime = timeStep;
        while (currentTime <= hours)
        {
            amebaAmount = amebaAmount * 2;
            Console.WriteLine(amebaAmount);
            currentTime = currentTime + timeStep;
        }
    }

}