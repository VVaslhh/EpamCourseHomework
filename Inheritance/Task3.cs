using System;

namespace Inheritance.Task3
{
    public class Figure
    {
        public int X { get; }
        public int Y { get; }
        public Figure(int x, int y)
        {
            X = x;
            Y = y;
        }
        public virtual void Draw()
        {
            Console.WriteLine($"Figure3 X:{X} Y:{Y}");
        }
    }

    public class Square : Figure
    {
        public Square(int x, int y) : base(x, y) { }
        public override void Draw()
        {
            Console.WriteLine($"Square3 X:{X} Y:{Y}");
        }
    }

    public class Rectangle : Figure
    {
        public Rectangle(int x, int y) : base(x, y) { }
        public override void Draw()
        {
            Console.WriteLine($"Rectangle3 X:{X} Y:{Y}");
        }
    }
}

