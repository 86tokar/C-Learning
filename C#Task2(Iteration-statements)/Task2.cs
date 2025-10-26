using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Task2_Iteration_statements_
{
    class Task2
    {
        int hoursAmeba = Methods.GetIntInput("Enter amount of hours for Task2 ");
        public static void CalculateAmeba(int hours)
        {
            int amebaAmount = 1;
            int timeStep = 3;
            for (int currentTime = timeStep; currentTime <= hours; currentTime += timeStep)
            {
                amebaAmount *= 2;
                Console.WriteLine(amebaAmount);
            }
        }

    }
}
