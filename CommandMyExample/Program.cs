using System;

namespace CommandMyExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stock abcStock = new Stock();
            //покупка товару
            BuyStock buyStockOrder = new BuyStock(abcStock);
            //продаж товару
            SellStock sellStockOrder = new SellStock(abcStock);

            //створуємо класа для виконання команд
            Broker broker = new Broker();
            //Робимо команду для покупки
            broker.takeOrder(buyStockOrder);
            //Робимо команду для продажу
            broker.takeOrder(sellStockOrder);

           broker.placeOrders();
        }
    }
}
