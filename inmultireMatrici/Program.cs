using System;

namespace inmultireMatrici
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = ReadMatrix(1);
            int[,] matrix2 = ReadMatrix(2);
            int[,] matrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

            if (matrix1.GetLength(1) != matrix2.GetLength(0))
                Console.WriteLine("Matricile nu pot fi inmultite!");
            else
            {
                Inmultire(matrix1, matrix2, matrix);
                PrintMatrix(matrix);
            }
        }

        static int[,] ReadMatrix(int nr)
        {
            Console.WriteLine($"Nr linii matrice{nr}:");
            int rowsCount = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Nr coloane matrice{nr}:");
            int colsCount = Int32.Parse(Console.ReadLine());

            int[,] matrix = new int[rowsCount, colsCount];
            for(int row=0; row<matrix.GetLength(0); row++)
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"[{row},{col}]:");
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
        static void Inmultire(int[,] matrix1, int[,] matrix2, int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    for (int i = 0; i < matrix1.GetLength(1); i++)
                        matrix[row, col] = matrix[row, col] + matrix1[row,i] * matrix2[i,col];
                }
        }
    }
}
