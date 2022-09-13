using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Facade
{
    public class ShapeMaker
    {
        private Shape circle;
        private Shape reactangle;
        private Shape square;

        public ShapeMaker()
        {
            circle = new Circle();
            reactangle = new Rectangle();
            square= new Square();
        }

        public void drawCircle()
        {
            circle.Draw();
        }
        public void drawRectangle()
        {
            reactangle.Draw();
        }
        public void drawSquare()
        {
            square.Draw();
        }
    }
}
