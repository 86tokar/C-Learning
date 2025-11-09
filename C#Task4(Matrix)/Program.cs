using C_Task4_Matrix_;
using System;
int[,] myMatrix = Methods.CreatePositiveIntMatrix(2, 3);

Console.WriteLine("Your matrix");
PrintMatrix(myMatrix);

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.ReadKey();