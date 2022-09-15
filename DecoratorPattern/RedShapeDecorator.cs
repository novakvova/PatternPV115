using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    // Class 3
    // Concrete class extending the abstract class
    // RedShapeDecorator.java
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(Shape decoratedShape) : base(decoratedShape)
        {
        }

        public override void draw()
        {
            decoratedShape.draw();
            setRedBorder(decoratedShape);
        }

        private void setRedBorder(Shape decoratedShape)
        {
            // Display message whenever function is called
            Console.WriteLine("Border Color: Red");
        }
    }
}
