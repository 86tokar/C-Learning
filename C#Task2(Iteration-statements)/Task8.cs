using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Task2_Iteration_statements_
{
    class Task8
    {
        public static void ShowTriangles()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(new string('*', i));
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine(new string('*', i));
            }
        }
    }
}
