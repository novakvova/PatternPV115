using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Proxy
{
    public class ProxyImage : Image
    {
        private RealImage realImage;
        private string fileName;

        public ProxyImage(string fileName)
        {
            this.fileName = fileName;
        }

        public void Display()
        {
            if(realImage == null)
            {
                realImage = new RealImage(fileName);
            }
            realImage.Display();
        }
    }
}
