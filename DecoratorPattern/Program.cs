using System;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an object of Shape interface
        // inside the main() method
        Shape circle = new Circle();

        Shape redCircle
            = new RedShapeDecorator(new Circle());

        Shape redRectangle
            = new RedShapeDecorator(new Rectangle());

        // Display message
        Console.WriteLine("Circle with normal border");

        // Calling the draw method over the
        // object calls as created in
        // above classes

        // Call 1
        circle.draw();

            // Display message
           // Console.WriteLine("\nCircle of red border");

        // Call 2
        redCircle.draw();

            // Display message
            //Console.WriteLine("\nRectangle of red border");

        // Call 3
        redRectangle.draw();
        }
    }
}
