using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Task2_Iteration_statements
{
    public class Task4 : ITask
    {
        
        public void Execute()
        {
            int firstNum = Methods.GetIntInput("Enter first integer value ");
            int secondNum = Methods.GetIntInput("Enter second integer value ");
            int multiplication = 0;
            if (secondNum < 0)
            {
                firstNum = -firstNum;
                secondNum = -secondNum;
            }
            for (int i = 0; i < secondNum; i++)
            {
                multiplication = multiplication + firstNum;
            }
            Console.WriteLine(multiplication);
        }

    }
}
