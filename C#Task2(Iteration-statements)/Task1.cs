using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Task2_Iteration_statements  
{
    public class Task1 : ITask  
    {
        public void Execute()
        {
            int hours = Methods.GetIntInput("Enter amount of hours for Task1: ");  
            int firstHourKm = 10;  
            double currentDistance = firstHourKm;
            double totalDistance = firstHourKm;
            for (int h = 2; h <= hours; h++)
            {
                currentDistance *= 1.1;  
                totalDistance += currentDistance;
            }

            Console.WriteLine(totalDistance);
        }
    }
}
