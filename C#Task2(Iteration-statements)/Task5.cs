using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Task2_Iteration_statements_
{
    class Task5
    {
        public static void InchToCm()
        {
            int[] monics = new int[21];
            for (int i = 0; i < 21; i++)
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
}
