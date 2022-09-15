using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    // Rectangle.java
    public class Rectangle : Shape
    {

        // Overriding the method
        public void draw()
        {
            // /Print statement to execute when
            // draw() method of this class is called
            // later on in the main() method
            Console.WriteLine("Shape: Rectangle");
        }
    }
}
