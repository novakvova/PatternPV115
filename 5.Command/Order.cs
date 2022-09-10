using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Command
{
    /// <summary>
    /// Клас команд
    /// </summary>
    public interface Order
    {

        /// <summary>
        /// Виконати заказ
        /// </summary>
        void excecute();
    }
}
