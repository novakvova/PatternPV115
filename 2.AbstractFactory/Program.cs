using _2.AbstractFactory.Abstract;
using _2.AbstractFactory.Factory.Roshen;
using _2.AbstractFactory.Factory.Switoch;
using System;

namespace _2.AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Оберіть фабрику (R - Рошен, S - Світоч)?");
            char input = Console.ReadKey().KeyChar;
            RecipeFactory factory;
            switch (input)
            {
                case 'R':
                    factory = new RoshenFactory();
                    break;

                case 'S':
                    factory = new SwitochFactory();
                    break;

                default:
                    throw new NotImplementedException();

            }

            //Створюємо продукти даної фабрики, яку хоче клієнт
            Sandwich sandwich = factory.CreateSandwich(); //Хочу бутерброт
            var dessert = factory.CreateDessert(); //Хочу десерт

            Console.WriteLine("\nSandwich: " + sandwich.GetType().Name);
            Console.WriteLine("Dessert: " + dessert.GetType().Name);

            Console.ReadKey();
        }
    }
}
