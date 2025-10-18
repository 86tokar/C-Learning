using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Task2_Iteration_statements_
{
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
}
