using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Task2_Iteration_statements
{
    public class Task8:ITask
    {
        public void Execute()
        {
            for (int i = 1; i <= 5; i++) 
            {
                for (int j = 1; j <= 5; j++) 
                {
                    if (j <= 5 - i)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 5; i >= 1; i--) 
            {
                for (int j = 1; j <= 5; j++) 
                {
                    if (j <= 5 - i)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
