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
            int[] anyArray = Methods.CreateIntArray();
            GetSecondMaximum(anyArray);
        }
        public static void GetSecondMaximum(int[] arr)
        {
            int max = arr[0];
            int secondMax = arr[1];

            if (secondMax > max)
            {
                int temp = max;
                max = secondMax;
                secondMax = temp;
            }

            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    secondMax = max;
                    max = arr[i];
                }
                else if (arr[i] > secondMax)
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
