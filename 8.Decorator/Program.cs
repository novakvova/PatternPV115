using System;

namespace _8.Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle();
            Shape redCircle = new RedShapeDecorator(new Circle());
            Shape redRectangle = new RedShapeDecorator(new Rectangle());

            Console.WriteLine("__________________________");
            circle.draw();
            Console.WriteLine("__________________________");
            redCircle.draw();
            Console.WriteLine("__________________________");
            redRectangle.draw();
        }
    }
}
