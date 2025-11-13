namespace C_Task4_Matrix_
{
    public class Task5 : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Task 5: Reverse all diagonals' numbers in the matrix");

            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int columns = int.Parse(Console.ReadLine());
            var matrix = Methods.CreatePositiveIntMatrix(rows, columns);

            Methods.PrintMatrix(matrix);
            var revertedMatrix = RevertAllDiagonalNumbersInMatrix(matrix);
            Console.WriteLine("Reverted all diagonals' numbers in the matrix:");
            Methods.PrintMatrix(revertedMatrix);

        }

        public static int[,] RevertAllDiagonalNumbersInMatrix(int[,] matrix)
        {
            var rowsAmount = matrix.GetLength(0);
            var columnsAmount = matrix.GetLength(1);
            var revertedMatrix = new int[columnsAmount, rowsAmount];

            for (int i = 0; i < rowsAmount; i++)
            {
                for (int j = 0; j < columnsAmount; j++)
                {
                    revertedMatrix[j, i] = matrix[i, j];
                }
            }

            return revertedMatrix;
        }
    }
}