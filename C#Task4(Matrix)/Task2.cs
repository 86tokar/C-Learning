namespace C_Task4_Matrix_
{
    public class Task2 : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Task 2: Select all odd numbers from the matrix");

            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int columns = int.Parse(Console.ReadLine());
            var matrix = Methods.CreatePositiveIntMatrix(rows, columns);

            Methods.PrintMatrix(matrix);
            ReturnOddNumbers(matrix);

        }

        public static void ReturnOddNumbers(int[,] matrix)
        {
            Console.WriteLine("Odd numbers: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 != 0)
                        Console.WriteLine(matrix[i, j]);

                }
            }
        }
    }
}