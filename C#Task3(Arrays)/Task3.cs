using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Task3_Arrays_
{
    public class Task3 : ITask
    {
        public void Execute()
        {
            var anyArray = Methods.CreateIntArray();
            GetSecondMaximum(anyArray);
        }
        private static void GetSecondMaximum(int[] arr)
        {
            int max = int.MinValue;
            int secondMax = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    secondMax = max;
                    max = arr[i];
                }
                else if (arr[i] != max && arr[i] > secondMax)
                {
                    secondMax = arr[i];
                }
            }

            Console.WriteLine("Array elements:");
            foreach (int num in arr)
                Console.Write(num + " ");

            Console.WriteLine($"\nSecond maximum number: {secondMax}");
        }
    }
}
