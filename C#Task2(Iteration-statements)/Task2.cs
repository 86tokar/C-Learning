using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Task2_Iteration_statements
{
    public class Task2 : ITask
    {
        public void Execute()
        {   
            int hoursAmeba = Methods.GetIntInput("Enter amount of hours for Task2 ");
            int amebaAmount = 1;
            int timeStep = 3;
            for (int currentTime = timeStep; currentTime <= hoursAmeba; currentTime += timeStep)
            {
                amebaAmount *= 2;
                Console.WriteLine(amebaAmount);
            }
        }

    }
}
