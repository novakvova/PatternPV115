using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _9.Conposit
{
    public class Developer : Employee
    {
        private string _name;
        private long _id;
        private string _level;
        public Developer(string name, long id, string level)
        {
            _name = name;
            _id = id;
            _level = level;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"{_id} {_name} {_level}");
        }
    }
}
