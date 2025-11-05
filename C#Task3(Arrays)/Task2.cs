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
            var positiveNumbersInArrayWithRange = Methods.GetPositiveArrayWithRangeCheck();
            GetMaximumNumberInArray(positiveNumbersInArrayWithRange);
        }
        private static void GetMaximumNumberInArray(int[] positiveNumbers)
        {
            var maxNumber = positiveNumbers.Max();

            Console.WriteLine(maxNumber);
        }
    }
}
