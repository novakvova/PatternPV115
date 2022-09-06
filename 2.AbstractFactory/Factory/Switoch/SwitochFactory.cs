using _2.AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AbstractFactory.Factory.Switoch
{
    public class SwitochFactory : RecipeFactory
    {
        public override Dessert CreateDessert()
        {
            return new SwitochDessert();
        }

        public override Sandwich CreateSandwich()
        {
            return new SwitochSandwich();
        }
    }
}
