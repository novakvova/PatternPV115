﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Decorator
{
    public class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Shape: Circle");
        }
    }
}
