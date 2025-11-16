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
            var multiplicationMainDiagonal = DiagonalMultiplication(matrix, "mainDiagonal");
            Console.WriteLine($"multiplication on main: {multiplicationMainDiagonal}");

            var multiplicationSecondaryDiagonal = DiagonalMultiplication(matrix, "secondaryDiagonal");
            Console.WriteLine($"multiplication on secondary: {multiplicationSecondaryDiagonal}");
        }

        private static int DiagonalMultiplication(int[,] matrix, string diagonal)
        {
            var multiplicationDiagonal = 1;
            var columnsAmount = matrix.GetLength(1);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (diagonal == "mainDiagonal")
                    multiplicationDiagonal *= matrix[i, i];
                else if (diagonal == "secondaryDiagonal")
                    multiplicationDiagonal *= matrix[i, columnsAmount - 1 - i];
            }

            return multiplicationDiagonal;
        }
    }
}