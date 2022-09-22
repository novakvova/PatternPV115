using System;

namespace _14.Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComputerPart part = new Computer();
            part.accept(new ComputerPartDisplayVisitor());
        }
    }
}
