namespace C_Task4_Matrix_
{
    public class Task1 : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Task 1: Calculate sum of all even numbers on the main matrix diagonal");

            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int columns = int.Parse(Console.ReadLine());

            var matrix = Methods.CreatePositiveIntMatrix(rows, columns);
            var sumMainDiagonalEven = SumEvenMainDiagonal(matrix);
            Methods.PrintMatrix(matrix);
            Console.WriteLine($"Sum: {sumMainDiagonalEven}");
        }

        private static int SumEvenMainDiagonal(int[,] matrix)
        {
            var sumMainDiagonalEven = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, i] % 2 == 0)  
                sumMainDiagonalEven += matrix[i, i];   
            }

            return sumMainDiagonalEven;
        }
    }
}