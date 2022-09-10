using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Command
{
    /// <summary>
    /// Клас, який приймає команади для виконання
    /// </summary>
    public class Broker : Order
    {
        //Список команд
        private List<Order> _orders = new List<Order>();

        public Order Order
        {
            get => default;
            set
            {
            }
        }

        internal Program Program
        {
            get => default;
            set
            {
            }
        }

        public void TakeOrder(Order order)
        {
            //Додаємо команду
            _orders.Add(order);
        }

        public void PlaceOrders()
        {
            foreach (Order order in _orders)
            {
                order.excecute(); //Виконуємо команди
            }
            //Очисчаємо список комнад
            _orders.Clear();
        }
    }
}
