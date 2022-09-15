using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Conposit
{
    public class Manager : Employee
    {
        private string _name;
        private int _id;
        private string _position;

        public Manager(string name, int id, string position)
        {
            this._name = name;
            this._id = id;
            this._position = position;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"{_id} {_name} {_position}");
        }
    }
}
