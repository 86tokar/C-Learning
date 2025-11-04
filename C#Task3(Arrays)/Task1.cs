using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Task3_Arrays_
{
    public class Task1 : ITask
    {
        public void Execute()
        {
            int[] positiveNumbers = Methods.GetPositiveArrayFromKeyboard();
            VerifyAscArray(positiveNumbers);
        }
        public static void VerifyAscArray(int[] positiveNumbers)
        {
            for (int i = 0; i < positiveNumbers.Length - 1; i++)
            {
                if (positiveNumbers[i] >= positiveNumbers[i + 1])
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");
        }
    }
}
