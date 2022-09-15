using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Decorator
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(Shape decoratorShape) : base(decoratorShape)
        {
        }

        public override void draw()
        {
            //base.draw();
            _decoratorShape.draw();
            setRedBorder(_decoratorShape);

        }
        private void setRedBorder(Shape shape)
        {
            Console.WriteLine("Border color: RED");
        }
    }
}
