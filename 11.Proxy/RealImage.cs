using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Proxy
{
    public class RealImage : Image
    {
        private readonly string fileName;
        public RealImage(string fileName)
        {
            this.fileName = fileName;
            loadFromDisk(fileName);
        }
        public void Display()
        {
            Console.WriteLine("Display ");
        }
        private void loadFromDisk(string fileName)
        {
            Console.WriteLine("Loading "+fileName);
        }
    }
}
