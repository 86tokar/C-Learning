namespace C_Task4_Matrix_
{
    class Methods
    {
        public static int[,] CreatePositiveIntMatrix(int rows, int columns)
        {
            int[,] positiveIntMatrix = new int[rows, columns];
            Console.WriteLine($"Enter {rows * columns} positive enteger numbers for matrix");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    while (true)
                    {
                        Console.Write($"positiveIntMatrix[{i},{j}] = ");
                        string input = Console.ReadLine();

                        if (int.TryParse(input, out int value) && value > 0)
                        {
                            positiveIntMatrix[i, j] = value;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Enter positive integer number");
                        }
                    }
                }
            }

            return positiveIntMatrix;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

