using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public static class StaticRectangle
    {
        private static double height = 0, length = 0;

        private static void RectangleSides(CoordsOfPoint top_left_point, CoordsOfPoint bottom_right_point)
        {
            height = bottom_right_point.X - top_left_point.X;
            length = top_left_point.Y - bottom_right_point.Y;
        }

        public static double PerimeterStatic(CoordsOfPoint top_left_point, CoordsOfPoint bottom_right_point)
        {
            RectangleSides(top_left_point, bottom_right_point);
            double p = 2 * (height + length);
            Console.WriteLine("Perimeter of the rectangle is: {0}", p);
            return p;
        }

        public static double AreaStatic(CoordsOfPoint top_left_point, CoordsOfPoint bottom_right_point)
        {
            RectangleSides(top_left_point, bottom_right_point);
            double s = height * length;
            Console.WriteLine("Area of the rectangle is: {0}", s);
            return s;
        }
    }
}
