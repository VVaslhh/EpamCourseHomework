using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
     public class RectangleAutoImplementedProperties
    {
        private readonly double height, length;

        public RectangleAutoImplementedProperties(CoordsOfPoint topLeftPoint, CoordsOfPoint bottomRightPoint)
        {
            height = bottomRightPoint.X - topLeftPoint.X;
            length = topLeftPoint.Y - bottomRightPoint.Y;
        }

        public double PerimeterProperty => 2 * (height + length);

        public double AreaProperty => height * length;
    }
}
