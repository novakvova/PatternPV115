using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandMyExample
{
    /// <summary>
    /// Клас, який приймає команди для виконання
    /// </summary>
    public class Broker
    {
        //Список команд
        private List<Order> orderList = new List<Order>();

        public void takeOrder(Order order)
        {
            //Додаємо команду
            orderList.Add(order);
        }

        public void placeOrders()
        {
            //Виконуємо усі команди
            foreach (Order order in orderList)
            {
                order.execute();
            }
            //Очисчаємо список комнад
            orderList.Clear();
        }
    }
}
