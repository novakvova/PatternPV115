using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandMyExample
{
    /// <summary>
    /// Продаж конкретного товару
    /// </summary>
    public class SellStock : Order
    {
        private Stock abcStock;

        //Зберіємо товар для продажу
        public SellStock(Stock abcStock)
        {
            this.abcStock = abcStock;
        }

        public void execute()
        {
            abcStock.sell(); //продаємо товар - назва і кількість
        }
    }
}
