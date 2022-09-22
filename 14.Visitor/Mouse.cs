using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Visitor
{
    public class Mouse : ComputerPart
    {
        public void accept(ComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.visit(this);
        }
    }
}
