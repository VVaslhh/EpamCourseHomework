using System;

namespace Classes
{
    public struct CoordsOfPoint
    {
        public double X { get; set; }
        public double Y { get; set; }

        public CoordsOfPoint(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public CoordsOfPoint CoordsInput()
        {
            Console.Write("Enter X coordinate:");
            X = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y coordinate:");
            Y = Convert.ToDouble(Console.ReadLine());
            return new CoordsOfPoint(X, Y);
        }
    }
    public class Rectangle
    {
        private readonly double height, length;

        public Rectangle(CoordsOfPoint topLeftPoint, CoordsOfPoint bottomRightPoint)
        {
            height = bottomRightPoint.X - topLeftPoint.X;
            length = topLeftPoint.Y - bottomRightPoint.Y;
        }

        public double Perimeter()
        {
            double p = 2 * (height + length);
            Console.WriteLine("Perimeter of the rectangle is: {0}", p);
            return p;
        }

        public double Area()
        {
            double s = height * length;
            Console.WriteLine("Area of the rectangle is: {0}", s);
            return s;
        }
    }
}
