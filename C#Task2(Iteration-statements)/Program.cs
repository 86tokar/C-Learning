using C_Task2_Iteration_statements;
using System;
namespace C_Task2_Iteration_statements
{
    class Program
    {
        static void Main()
        {
            ITask task1 = new Task1();
            task1.Execute();

            ITask task2 = new Task2();
            task2.Execute();

            ITask task3 = new Task3();
            task3.Execute();

            ITask task4 = new Task4();
            task4.Execute();

            ITask task5 = new Task5();
            task5.Execute();

            ITask task6 = new Task6();
            task6.Execute();

            ITask task7 = new Task7();
            task6.Execute();

            ITask task8 = new Task8();
            task8.Execute();
            Console.ReadLine();


            //Task5.InchToCm();
            //Task6.EvenNum();
            //Task7.OddNum();
            //Task8.ShowTriangles();
            //Console.ReadLine();
        }
    }
}



