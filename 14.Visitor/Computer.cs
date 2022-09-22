using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _14.Visitor
{
    public class Computer : ComputerPart
    {

        ComputerPart[] parts;

        public Computer()
        {
            parts = new ComputerPart[] { new Mouse(), new Keyboard(), new MonitorPC() };
        }


        public void accept(ComputerPartVisitor computerPartVisitor)
        {
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i].accept(computerPartVisitor);
            }
            computerPartVisitor.visit(this);
        }
    }
}
