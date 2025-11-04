using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Task3_Arrays_
{
    public class Task2 : ITask
    {
        public void Execute()
        {
            int[] positiveNumbersInArrayWithRange = Methods.GetPositiveArrayWithRangeCheck();
            GetMaximumNumberInArray(positiveNumbersInArrayWithRange);
        }
        public static void GetMaximumNumberInArray(int[] positiveNumbers)
        {
            int maxNumber = positiveNumbers.Max();

            Console.WriteLine(maxNumber);
        }
    }
}
