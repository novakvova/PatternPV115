using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Bridge
{
    /// <summary>
    /// Малювання зелених ліній
    /// </summary>
    public class GreenCirtcle : DrawAPI
    {

        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine($"Малюємо ЗЕЛЕНЕ коло -- радіус: {radius}, x: {x}, y: {y}") ;
        }
    }
}
