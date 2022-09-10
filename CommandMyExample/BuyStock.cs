using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandMyExample
{
    /// <summary>
    /// Клас для покупи конкреного твоару
    /// </summary>
    public class BuyStock : Order
    {
        private Stock abcStock;

        public BuyStock(Stock abcStock)
        {
            this.abcStock = abcStock; //Зберігаємо запит - назва і кількість
        }

        public void execute()
        {
            abcStock.buy(); //Проводимо покупку
        }
    }
}
