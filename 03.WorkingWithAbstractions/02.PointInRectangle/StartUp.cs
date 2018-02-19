using System;
using System.Linq;


    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var checksNum = int.Parse(Console.ReadLine());

            Point top = new Point(input[0], input[1]);
            Point bottom = new Point(input[2], input[3]);

            Rectangle rect = new Rectangle(top, bottom);

            for (int cnt = 0; cnt < checksNum; cnt++)
            {
                var inputPoint = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                Point point = new Point(inputPoint[0], inputPoint[1]);
                Console.WriteLine(rect.Contains(point));
            }

        }
    }

