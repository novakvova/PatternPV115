using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Obsaever
{
    public class PeterObserver : AppObserver
    {
        public PeterObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.attach(this);
        }
        public override void Update()
        {
            Console.WriteLine("Десяковий спостерігач: "+ this.subject.State);
        }
    }
}
