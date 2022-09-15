using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Decorator
{
    public abstract class ShapeDecorator : Shape
    {
        protected Shape _decoratorShape;
        public ShapeDecorator(Shape decoratorShape)
        {
            _decoratorShape = decoratorShape;
        }

        public override void draw()
        {
            _decoratorShape.draw();
        }
    }
}
