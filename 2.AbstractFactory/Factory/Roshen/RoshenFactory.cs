using _2.AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AbstractFactory.Factory.Roshen
{
    public class RoshenFactory : RecipeFactory
    {
        public override Dessert CreateDessert()
        {
            return new RoshenDesert();
        }

        public override Sandwich CreateSandwich()
        {
            return new RoshenSandwich();
        }
    }
}
