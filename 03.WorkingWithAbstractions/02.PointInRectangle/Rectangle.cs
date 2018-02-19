using System;
using System.Collections.Generic;
using System.Text;


    public class Rectangle
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }

        public Rectangle(Point topLeft, Point bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }

        public bool Contains(Point point)
        {
            var topX = TopLeft.X;
            var topY = TopLeft.Y;

            var bottomX = BottomRight.X;
            var bottomY = BottomRight.Y;

            return topX <= point.X && bottomX >= point.X && topY <= point.Y && bottomY >= point.Y;
        }
    }

