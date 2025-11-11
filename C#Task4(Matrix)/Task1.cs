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

        public static int SumEvenMainDiagonal(int[,] matrix)
        {
            var sumMainDiagonalEven = 0;
            var mainDiagonalLength = Math.Min(matrix.GetLength(0), matrix.GetLength(1)); 
            for (int i = 0; i < mainDiagonalLength; i++)
            {
                if (matrix[i, i] % 2 == 0)  
                sumMainDiagonalEven += matrix[i, i];   
            }

            return sumMainDiagonalEven;
        }
    }
}