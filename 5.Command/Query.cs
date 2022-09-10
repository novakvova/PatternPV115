using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Command
{
    /// <summary>
    /// Запит, який ми хочемо викнати
    /// </summary>
    public class Query
    {
        private String name = "BMW";
        private int quantity = 10;
        public  Query() { }

        public Query(string name, int quantity)
        {
            this.name = name;
            this.quantity = quantity;
        }

        internal Program Program
        {
            get => default;
            set
            {
            }
        }

        public void Buy()
        {
            Console.WriteLine($"Виконано {name} - {quantity} покупку") ;
        }
        public void Sell()
        {
            Console.WriteLine($"Виконано {name} - {quantity} продаж");
        }
    }
}
