using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Task2_Iteration_statements
{
    public class Task3:ITask
    {
        public void Execute()
        {
            int amountOfElementsInArray = Methods.GetIntInput("Enter amount of array elements for Task3 ");
            int[] taskArray = new int[amountOfElementsInArray + 1];

            for (int i = 0; i <= amountOfElementsInArray; i++)
            {
                taskArray[i] = i;
            }

            int sum = 0;
            foreach (int i in taskArray)
            {
                if (i > 0)
                {
                    sum += taskArray[i];
                }
            }
            Console.WriteLine(sum);
        }

    }
}
