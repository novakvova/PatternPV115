using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    // Class 2
    // Abstract class
    // ShapeDecorator.java
    public abstract class ShapeDecorator : Shape
    {

        // Protected variable
        protected Shape decoratedShape;

        // Method 1
        // Abstract class method
        public ShapeDecorator(Shape decoratedShape)
        {
            // This keywordd refers to current object itself
            this.decoratedShape = decoratedShape;
        }

        // Method 2 - draw()
        // Outside abstract class
        public virtual void draw() { 
            decoratedShape.draw(); 
        }
    }
}
