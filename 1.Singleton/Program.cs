using _1.Singleton.Data;
using System;
using System.Runtime.InteropServices;

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
                            var myDb = SingletonePattern.GetInstance();
                            TypedReference tr = __makeref(myDb);
                            Console.WriteLine("myDb address = {0}", tr.GetHashCode());
                            foreach (var item in myDb.Girls)
                            {
                                Console.WriteLine("Name: "+ item.Name);
                            }
                        }
                        break;
                    case 2:
                        {
                            Girl girl = new Girl()
                            {
                                Age = 20,
                                Hair = "Біло-Рижа",
                                Weight = 85
                            };
                            //Console.WriteLine("Адреса дівчини {0}", __makeref(girl).GetHashCode());
                            Console.WriteLine("Ім'я:");
                            girl.Name = Console.ReadLine();
                            var myDb = SingletonePattern.GetInstance();
                            TypedReference tr = __makeref(myDb);
                            Console.WriteLine("myDb address = {0}", tr.GetHashCode());
                            myDb.Girls.Add(girl);
                            myDb.SaveChanges();
                        }
                        break;
                }
            } while (action!=0);

        }
    }
}
