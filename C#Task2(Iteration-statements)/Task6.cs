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
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            for (int i = 0; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }

        }
    }
}
