using System;
using System.Threading;

namespace _15.Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User robert = new User("Robert");
            User john = new User("John");

            robert.sendMessage("Hi! John!");
            Thread.Sleep(5000);
            john.sendMessage("Hello! Robert!");
        }
    }
}
