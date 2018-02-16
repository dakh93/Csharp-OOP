using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.RectangleIntersection
{

    public class Rectangle
    {
        public string Id { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }

        public double HorizontalCord { get; set; }
        public double VerticalCord { get; set; }

        public void IntersectionCheck(Rectangle first, Rectangle second)
        {
            double x1 = Math.Max(first.HorizontalCord, second.HorizontalCord);
            double x2 = Math.Min(first.HorizontalCord + first.Width, second.HorizontalCord + second.Width);
            double y1 = Math.Max(first.VerticalCord, second.VerticalCord);
            double y2 = Math.Min(first.VerticalCord + first.Height, second.VerticalCord + second.Height);

            if (x2 >= x1 && y2 >= y1)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }

}