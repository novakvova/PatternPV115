using System;
using System.Xml;

namespace _9.Conposit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer ivan = new Developer("Машко Іван Болт", 1023, "Тройнік");
            Developer chrystyna = new Developer("Христина Омельно Давайко", 2098, "Lead");

            Manager max = new Manager("Коржик Максим Попрошайка", 1092, "Охоронець");
            Manager dima = new Manager("Біквіт Діма Огірков", 1091, "Паркувальник - стажор");

            Company olx = new Company();
            olx.Add(ivan);
            olx.Add(chrystyna);
            olx.Add(max);
            olx.Add(dima);
            olx.ShowInfo();
        }
    }
}
