using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Bridge
{
    /// <summary>
    /// Клас для малювання ліній
    /// </summary>
    public interface DrawAPI
    {

        public void DrawCircle(int radius, int x, int y);
    }
}
