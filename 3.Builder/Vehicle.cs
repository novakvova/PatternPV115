using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Builder
{
    /// <summary>
    /// The 'Product' class - транспортний засіб
    /// </summary>
    public class Vehicle
    {
        //Тип Т/З
        private string _vehicleType;
        //Частини, з якик сладаєтсья Т/З
        private Dictionary<string, string> _parts =
          new Dictionary<string, string>();
        // Constructor
        public Vehicle(string vehicleType)
        {
            this._vehicleType = vehicleType;
        }
        // Indexer
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }
        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type: {0}", _vehicleType);
            Console.WriteLine(" Frame : {0}", _parts["frame"]);
            Console.WriteLine(" Engine : {0}", _parts["engine"]);
            Console.WriteLine(" #Wheels: {0}", _parts["wheels"]);
            Console.WriteLine(" #Doors : {0}", _parts["doors"]);
        }
    }
}
