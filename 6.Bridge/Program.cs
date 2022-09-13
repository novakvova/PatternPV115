using System;

namespace _6.Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape greenCircle = new Circle(25,20, 10, new GreenCirtcle());
            Shape redCircle = new Circle(15,40, 15, new RedCircle());

            greenCircle.Draw();
            redCircle.Draw();
        }
    }
}
