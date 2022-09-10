using System;

namespace _5.Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Паттерн команд!");
            Query audiQuery = new Query("Audi 3.0", 1);
            //Створюємо команди
            BuyQuery buyQuery = new BuyQuery(audiQuery);
            Query bmwQuery = new Query("BMW 3", 2);  
            SellQuery sellQuery = new SellQuery(bmwQuery);

            Broker broker = new Broker();
            broker.TakeOrder(buyQuery);
            broker.TakeOrder(sellQuery);

            //виконати команди для брокера
            broker.PlaceOrders();

        }
    }
}
