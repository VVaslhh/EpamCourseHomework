using System;

namespace Inheritance.Task2
{
    public abstract class Figure
    {
        public int X { get; }
        public int Y { get; }
        protected Figure(int x, int y)
        {
            X = x;
            Y = y;
        }
        public abstract void Draw();
    }

    public class Square : Figure
    {
        public Square(int x, int y) : base(x, y) { }
        public override void Draw()
        {
            Console.WriteLine($"Square2 X:{X} Y:{Y}");
        }
    }

    public class Rectangle : Figure
    {
        public Rectangle(int x, int y) : base(x, y) { }
        public override void Draw()
        {
            Console.WriteLine($"Rectangle2 X:{X} Y:{Y}");
        }
    }
}
