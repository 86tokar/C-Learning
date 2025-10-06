using System;

class Program
{
    static void Main()
    {
        //int hoursDistance = GetIntInput("Enter amount of hours for Task1 ");
        //Task1.CalculateDistance(hoursDistance);


        //int hoursAmeba = GetIntInput("Enter amount of hours for Task2 ");
        //Task2.CalculateAmeba(hoursAmeba);


        //int amountOfElementsInArray = GetIntInput("Enter amount of array elements for Task3 ");
        //Task3.CalculatePositiveArray(amountOfElementsInArray);

        //int firstNum = GetIntInput("Enter first integer value ");
        //int secondNum = GetIntInput("Enter second integer value ");
        //Task4.MultNum(firstNum, secondNum);

        //Task5.InchToCm();
        

        //Task6.EvenNum();


        //Task7.OddNum();

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


class Task3
{
    public static void CalculatePositiveArray(int arrayLength)
    {
        int[] taskArray = new int[arrayLength + 1];

        for (int i = 0; i <= arrayLength; i++)
        {
            taskArray[i] = i;
        }

        int sum = 0;
        foreach (int i in taskArray)
        {
            if (i > 0)
            {
                sum = sum + taskArray[i];
            }

        }
        Console.WriteLine(sum);
    }

}


class Task4
{
    public static void MultNum(int firstNum, int secondNum)
    {
        int multiplication = 0;
        if (secondNum < 0)
        {
            firstNum = -firstNum;
            secondNum = -secondNum;
        }
        for (int i = 0; i < secondNum; i = i + 1)
        {
            multiplication = multiplication + firstNum;
        }
        Console.WriteLine(multiplication);
    }

}

class Task5
{
    public static void InchToCm()
    {
        int[] monics = new int[21];
        for (int i = 0; i < 21; i = i + 1)
        {
            monics[i] = i + 1;
        }
        foreach (int mon in monics)
        {
            double cm = mon * 2.54;
            Console.WriteLine(cm);
        }

    }

}


class Task6
{
    public static void EvenNum()
    {
        int[] num = new int[101];
        for (int i = 0; i <= 100; i++)
        {
            num[i] = i;
        }
        foreach (int el in num)
        {
            if (el % 2 == 0)
            {
                Console.WriteLine(el);
            }
        }
        for (int i = 0; i <= 100; i = i + 2)
        {
            Console.WriteLine(i);
        }

    }
}


class Task7
{
    public static void OddNum()
    {
        int[] num = new int[101];


        for (int i = 0; i <= 100; i++)
        {
            num[i] = i;
        }


        foreach (int el in num)
        {
            if (el % 2 != 0)
            {
                Console.WriteLine(el);
            }
        }

        for (int i = 1; i <= 100; i = i + 2)
        {
            Console.WriteLine(i);
        }
    }
}


class Task8
{
    public static void ShowTriangles()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(new string('*', i));
        }
        Console.WriteLine();
        Console.WriteLine();
        for (int i = 5; i >= 1; i--)
        {
            Console.WriteLine(new string('*', i));
        }
    }
}



