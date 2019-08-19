using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public static class StaticCircle
    {
        private const double pi = 3.14159;

        public static double CircumferenceOfCircle(double radius)
        {
            return 2 * pi * radius;
        }

        public static double AreaOfCircle(double radius)
        {
            return pi * radius * radius;
        }
    }
}
