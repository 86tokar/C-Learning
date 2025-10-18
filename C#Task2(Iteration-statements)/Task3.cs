using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Task2_Iteration_statements_
{
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
}
