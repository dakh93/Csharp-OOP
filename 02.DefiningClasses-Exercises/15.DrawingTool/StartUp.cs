using System;

namespace _15.DrawingTool
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();

            if (figure == "Square")
            {
                var side = int.Parse(Console.ReadLine());

                DrawSquare(side);

            }
            else if (figure == "Rectangle")
            {
                var width = int.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());

                DrawRectangle(width, height);
            }


        }

        private static void DrawRectangle(int width, int height)
        {

            
                Console.Write("|");
                Console.Write(new string('-', width));
                Console.WriteLine("|");

                for (int i = 0; i < height - 2; i++)
                {
                    Console.Write("|");
                    Console.Write(new string(' ', width));
                    Console.WriteLine("|");
                }

                Console.Write("|");
                Console.Write(new string('-', width));
                Console.WriteLine("|");
            
        }

        private static void DrawSquare(int side)
        {
            
            
            Console.Write("|");
            Console.Write(new string('-',side));
            Console.WriteLine("|");

            for (int i = 0; i < side - 2; i++)
            {
                Console.Write("|");
                Console.Write(new string(' ', side));
                Console.WriteLine("|");
            }

            Console.Write("|");
            Console.Write(new string('-', side));
            Console.WriteLine("|");
        }
    }
}
