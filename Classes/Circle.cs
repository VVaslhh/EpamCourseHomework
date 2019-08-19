using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Circle
    {
        private const double pi = 3.14159;

        public double CircumferenceOfCircle(double radius)
        {
            return 2 * pi * radius;
        }

        public double AreaOfCircle(double radius)
        {
            return pi * radius * radius;
        }
    }
}
