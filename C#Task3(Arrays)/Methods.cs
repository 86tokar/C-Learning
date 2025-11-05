using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Task3_Arrays_
{
    class Methods
    {
        public static int GetIntInput(string prompt)
        {
            int result;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out result))
                    return result;
                else Console.WriteLine("Incorrect input, please inter integer number");
            }
        }

        public static int GetPositiveIntInput(string prompt = "")
        {
            int result;
            while (true)
            {
                result = GetIntInput(prompt);
                if (result > 0)
                    return result;
                else Console.WriteLine("Incorrect input, enter positive integer number please");
            }
        }

        public static int[] GetPositiveArrayFromKeyboard()
        {
            Console.Write("Enter amount of elements in the array: ");
            int amount = GetPositiveIntInput();

            int[] array = new int[amount];

            for (int i = 0; i < amount; i++)
            {
                array[i] = GetPositiveIntInput($"Enter element {i + 1}: ");
            }

            return array;
        }

        public static int[] GetPositiveArrayWithRangeCheck()
        {
            int amount = GetPositiveIntInput("Enter amount of elements in the array: ");
            int[] array = new int[amount];

            for (int i = 0; i < amount; i++)
            {
                int value = GetIntInput("Enter element(0–16)");

                if (value < 0 || value > 16)
                {
                    Console.WriteLine("Element is out of range (0–16). Please enter again.");
                    i--;
                }
                else
                {
                    array[i] = value;
                }
            }

            return array;
        }

        public static int[] CreateIntArray()
        {
            int integerArray = GetIntInput("Enter amounts of elements");
            int[] arr = new int[integerArray];

            for (int i = 0; i < integerArray; i++)
            {
                arr[i] = GetIntInput($"enter element {i + 1}: ");
            }

            return arr;
        }
    }
}
