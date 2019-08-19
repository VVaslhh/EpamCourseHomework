using System;

namespace Inheritance.Task4
{
    public class Figure : IDrawable
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
            Console.WriteLine($"Figure4 X:{X} Y:{Y}");
        }
    }

    public class Square : Figure
    {
        public Square(int x, int y) : base(x, y) { }
        public override void Draw()
        {
            Console.WriteLine($"Square4 X:{X} Y:{Y}");
        }
    }

    public class Rectangle : Figure
    {
        public Rectangle(int x, int y) : base(x, y) { }
        public override void Draw()
        {
            Console.WriteLine($"Rectangle4 X:{X} Y:{Y}");
        }
    }
}
