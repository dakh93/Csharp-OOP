using System;

namespace _01.RhombusOfStars
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PrintRow(n, i);
            }
            for (int i = n - 1; i >= 1; i--)
            {
                PrintRow(n, i);
            }

        }

        private static void PrintRow(int rhombSize, int rowSize)
        {

            for (int i = 0; i < rhombSize - rowSize ; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < rowSize; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        
    }
}
