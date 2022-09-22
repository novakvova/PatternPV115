using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Visitor
{
    public class ComputerPartDisplayVisitor : ComputerPartVisitor
    {
        public void visit(Computer computer)
        {
            Console.WriteLine("Видаємо ПК");
        }

        public void visit(Mouse mouse)
        {
            Console.WriteLine("Видаємо мишку");
        }

        public void visit(Keyboard keyboard)
        {
            Console.WriteLine("Видаємо клавіатуру");
        }

        public void visit(MonitorPC monitor)
        {
            Console.WriteLine("Видаємо монітор");
        }
    }
}
