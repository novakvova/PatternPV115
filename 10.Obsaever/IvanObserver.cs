using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Obsaever
{
    public class IvanObserver : AppObserver
    {
        public IvanObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.attach(this);
        }
        public override void Update()
        {
            Console.WriteLine("Двійковий спотерігач: "+ this.subject.State);
        }
    }
}
