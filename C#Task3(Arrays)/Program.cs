using System;
using C_Task3_Arrays_; 

ITask task1 = new Task1();
task1.Execute();

ITask task2 = new Task2();
task2.Execute();

ITask task3 = new Task3();
task3.Execute();

Console.WriteLine("Press any key to exit...");
Console.ReadKey();
