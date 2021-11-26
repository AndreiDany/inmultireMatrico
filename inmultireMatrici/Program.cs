using System;

namespace inmultireMatrici
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = ReadMatrix();
            int[,] matrix2 = ReadMatrix();
            int[,] matrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

            PrintMatrix(matrix);
        }

        static int[,] ReadMatrix()
        {
            int rowsCount = Int32.Parse(Console.ReadLine());
            int colsCount = Int32.Parse(Console.ReadLine());

            int[,] matrix = new int[rowsCount, colsCount];
            for(int row=0; row<matrix.GetLength(0); row++)
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.WriteLine($"[{row},{col}]:");
                    matrix[row, col] = Int32.Parse(Console.ReadLine());
                }
            return matrix; 

        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col],4}");

                }
                Console.WriteLine();
            }
        }
    }
}
