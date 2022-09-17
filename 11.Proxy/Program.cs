using System;

namespace _11.Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Image image = new ProxyImage("app.jpg");
            image.Display();
            image.Display();
        }
    }
}
