using System;

namespace laba1_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 5, n = 6;
            double[,] matrix = SetMatrix(m, n);
            ShowMatrix(matrix);
            FindMinRow(matrix, out int iMin);
            double[,] newMatrix = DeleteRow(matrix, iMin);
            ShowMatrix(newMatrix);

        }

        static double[,] DeleteRow(double[,] matrix, int iToDel)
        {
            double[,] newMatrix = new double[matrix.GetLength(0) - 1, matrix.GetLength(1)];
            for (int i = 0; i < iToDel; i++)
                for (int j = 0; j < newMatrix.GetLength(1); j++)
                {
                    newMatrix[i, j] = matrix[i, j];
                }
            for (int i = iToDel; i < newMatrix.GetLength(0); i++)
                for (int j = 0; j < newMatrix.GetLength(1); j++)
                {
                    newMatrix[i, j] = matrix[i + 1, j];
                }

            return newMatrix;
        }

        static void FindMinRow(double[,] matrix, out int iMin)
        {
            double min = matrix[0, 0];
            iMin = -1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        iMin = i;
                    }
                }
            }
        }

        static double[,] SetMatrix(int m, int n)
        {
            double[,] matrix = new double[m, n];
            Random rnd = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(10, 50) + rnd.NextDouble();
                }
            }
            return matrix;
        }

        static void ShowMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}
