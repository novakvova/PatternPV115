using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Bridge
{
    /// <summary>
    /// Ми можемо малювати коло
    /// </summary>
    public class Circle : Shape
    {
        private int x;
        private int y;
        private int radius;
        public Circle(int x, int y, int radius, DrawAPI drawAPI) : base(drawAPI)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void Draw()
        {
            drawAPI.DrawCircle(radius,x,y);
        }
    }
}
