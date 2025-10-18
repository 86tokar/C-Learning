using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Task2_Iteration_statements_
{
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
}
