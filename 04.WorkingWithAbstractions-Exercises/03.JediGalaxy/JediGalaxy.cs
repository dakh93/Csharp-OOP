using System;
using System.Linq;

namespace _03.JediGalaxy
{
    class JediGalaxy
    {

        static void Main()
        {
            int[] dimestions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int rows = dimestions[0];
            int cols = dimestions[1];

            int[,] matrix = new int[rows, cols];

            FillMatrix(rows, cols, matrix);

            string command = Console.ReadLine();
            long sum = 0;
            while (command != "Let the Force be with you")
            {
                int[] ivoPosition =
                    command
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int[] evilPosition =
                    Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int evilRow = evilPosition[0];
                int evilCol = evilPosition[1];

                DestroyStars(matrix, evilRow, evilCol);

                int ivoRow = ivoPosition[0];
                int ivoCol = ivoPosition[1];

                 sum += SumStarsValues(matrix, ivoRow,  ivoCol);

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);

        }

        private static long SumStarsValues(int[,] matrix, int ivoRow, int ivoCol)
        {
            long sum = 0;
            while (ivoRow >= 0 && ivoCol < matrix.GetLength(1))
            {
                if (ivoRow >= 0 && ivoRow < matrix.GetLength(0) &&
                    ivoCol >= 0 && ivoCol < matrix.GetLength(1))
                {
                    sum += matrix[ivoRow, ivoCol];
                }

                ivoCol++;
                ivoRow--;
            }
            return sum;
        }

        private static void DestroyStars(int[,] matrix, int evilRow, int evilCol)
        {
            while (evilRow >= 0 && evilCol >= 0)
            {
                if (evilRow >= 0 && evilRow < matrix.GetLength(0) &&
                    evilCol >= 0 && evilCol < matrix.GetLength(1))
                {
                    matrix[evilRow, evilCol] = 0;
                }
                evilRow--;
                evilCol--;
            }
        }

        private static void FillMatrix(int rows, int cols, int[,] matrix)
        {
            int value = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = value++;
                }
            }
        }
    }
}
