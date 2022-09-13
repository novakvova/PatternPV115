using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Bridge
{
    /// <summary>
    /// Малювання червоних ліній
    /// </summary>
    public class RedCircle : DrawAPI
    {

        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine($"Малюємо Червоне коло радіус: {radius}, x: {x}, y: {y}");
        }
    }
}
