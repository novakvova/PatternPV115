using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandMyExample
{
    /// <summary>
    /// Клас команди
    /// </summary>
    public interface Order
    {
        //Виконання команди
        void execute();
    }
}
