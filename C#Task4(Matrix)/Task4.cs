namespace C_Task4_Matrix_
{
    public class Task4 : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Task 4: Calculate the sum of even numbers, located higher than the main matrix diagonal");

            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int columns = int.Parse(Console.ReadLine());
            var matrix = Methods.CreatePositiveIntMatrix(rows, columns);

            Methods.PrintMatrix(matrix);
            var sumEvenNumbersAboveMainDiagonal = SumEvenNumbersAboveMainDiagonal(matrix);
            Console.WriteLine($"sum of even numbers, located higher than the main matrix diagonal: {sumEvenNumbersAboveMainDiagonal}");

        }

        private static int SumEvenNumbersAboveMainDiagonal(int[,] matrix)
        {
            var sumEvenNumbersAboveMainDiagonal = 0;
            var columnsAmount = matrix.GetLength(1);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i + 1; j < columnsAmount; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                        sumEvenNumbersAboveMainDiagonal += matrix[i, j];
                }
            }

            return sumEvenNumbersAboveMainDiagonal;
        }
    }
}