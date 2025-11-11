namespace C_Task4_Matrix_
{
    public class Task3 : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Task 3: Multiple all numbers on main and secondary matrix diagonals");

            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int columns = int.Parse(Console.ReadLine());
            var matrix = Methods.CreatePositiveIntMatrix(rows, columns);

            Methods.PrintMatrix(matrix);
            var multiplicationMainDiagonal = MainDiagonalMultiplication(matrix);
            Console.WriteLine($"multiplication on main: {multiplicationMainDiagonal}");

            var multiplicationSecondaryDiagonal = SecondaryDiagonalMultiplication(matrix);
            Console.WriteLine($"multiplication on secondary: {multiplicationSecondaryDiagonal}");
        }

        public static int MainDiagonalMultiplication(int[,] matrix)
        {
            var multiplicationMainDiagonal = 1;
            var DiagonalLength = Math.Min(matrix.GetLength(0), matrix.GetLength(1));
            for (int i = 0; i < DiagonalLength; i++)
                multiplicationMainDiagonal *= matrix[i, i];
            return multiplicationMainDiagonal;
        }
        public static int SecondaryDiagonalMultiplication(int[,] matrix)
        {
            var multiplicationSecondaryDiagonal = 1;
            var DiagonalLength = Math.Min(matrix.GetLength(0), matrix.GetLength(1));
            var columnsAmount = matrix.GetLength(1);
            for (int i = 0; i < DiagonalLength; i++)
                multiplicationSecondaryDiagonal *= matrix[i, columnsAmount - 1 - i];
            return multiplicationSecondaryDiagonal;
        }
    }
}