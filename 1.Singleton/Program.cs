using _1.Singleton.Data;
using System;

namespace _1.Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int action = 0;
            do
            {
                Console.WriteLine("Оберіть операцію");
                Console.WriteLine("0. Мене не цікавлять двічата");
                Console.WriteLine("1. Показати дівчат");
                Console.WriteLine("2. Додати дівчину");
                action = int.Parse(Console.ReadLine());
                switch(action)
                {
                    case 1:
                        {
                            foreach(var item in SingletonePattern.GetInstance().Girls)
                            {
                                Console.WriteLine("Name: "+ item.Name);
                            }
                        }
                        break;
                    case 2:
                        Girl girl = new Girl()
                        {
                            Age=20,
                            Hair="Біло-Рижа",
                            Weight=85
                        };
                        Console.WriteLine("Ім'я:");
                        girl.Name=Console.ReadLine();
                        var myDb = SingletonePattern.GetInstance();
                        myDb.Girls.Add(girl);
                        myDb.SaveChanges(); 
                        break;
                }
            } while (action!=0);

        }
    }
}
