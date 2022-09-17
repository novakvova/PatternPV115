using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _10.Obsaever
{
    public class Bitoc
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; } //double
        public override string ToString()
        {
            return $"{Id} '{Name}' {Price}";
        }
    }
}
