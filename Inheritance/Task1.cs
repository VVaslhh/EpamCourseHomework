using System;

namespace Inheritance.Task1
{
    public abstract class Figure
    {
        public abstract void Draw();
    }

    public class Square : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("Square1");
        }
    }

    public class Rectangle : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle1");
        }
    }
}

