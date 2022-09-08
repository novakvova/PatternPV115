using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Builder
{
    // <summary>
    /// The 'Builder' abstract class - Будівельна компанія - Будує автомобілі
    /// </summary>
    public abstract class VehicleBuilder
    {
        protected Vehicle vehicle;
        // Gets vehicle instance
        public Vehicle Vehicle
        {
            get { return vehicle; }
        }
        // Abstract build methods
        public abstract void BuildFrame(); //Частини
        public abstract void BuildEngine(); //Двигун
        public abstract void BuildWheels(); //Колеса
        public abstract void BuildDoors(); //Двері
    }
}
