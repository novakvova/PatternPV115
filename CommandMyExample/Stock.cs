using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandMyExample
{
    /// <summary>
    /// Запит для виконання команди
    /// </summary>
    public class Stock
    {

        private String name = "ABC";
        private int quantity = 10;
        //Покупка
        public void buy()
        {
            Console.WriteLine("Брокер [ Назва: " + name + ", Кількість: " + quantity +" ] купив");
        }
        //Продаж
        public void sell()
        {
            Console.WriteLine("Брокер [ Назва: " + name + ", Кількість: " + quantity +" ] продав");
        }
    }
}
