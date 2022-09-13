using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Bridge
{
    /// <summary>
    /// Описуємо зальну фігуру для малювання
    /// </summary>
    public abstract class Shape
    {
        protected DrawAPI drawAPI;

        protected Shape(DrawAPI drawAPI)
        {
            this.drawAPI = drawAPI;
        }
        public abstract void Draw();
    }
}
