using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.RectangleIntersection
{


    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int rectNum = int.Parse(input[0]);
            int checks = int.Parse(input[1]);

            Dictionary<string,Rectangle> rectangles = new Dictionary<string, Rectangle>();
            for (int i = 0; i < rectNum; i++)
            {
                var currInput = Console.ReadLine().Split(' ');

                var id = currInput[0];
                var width = double.Parse(currInput[1]);
                var height = double.Parse(currInput[2]);

                double horCord = double.Parse(currInput[3]);
                double verCord = double.Parse(currInput[4]);

                Rectangle rect = new Rectangle();
                rect.Id = id;
                rect.Height = height;
                rect.Width = width;
                rect.HorizontalCord = horCord;
                rect.VerticalCord = verCord;

                rectangles[id] = rect;
            }
            
            

            for (int i = 0; i < checks; i++)
            {
                var rects = Console.ReadLine().Split(' ');
                var first = rects[0];
                var second = rects[1];

                rectangles[first].IntersectionCheck(rectangles[first], rectangles[second]);

            }
        }
    }

}
