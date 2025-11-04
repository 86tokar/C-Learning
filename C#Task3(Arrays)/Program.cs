using System;
namespace C_Task3_Arrays_
{
    class Program
    {
        static void Main()
        {
            ITask Task1 = new Task1();
            Task1.Execute();

            ITask Task2 = new Task2();
            Task2.Execute();

            ITask Task3 = new Task3();
            Task3.Execute();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}



