﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Visitor
{
    public interface ComputerPart
    {
        public void accept(ComputerPartVisitor computerPartVisitor);
    }
}
