using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Obsaever
{
    public abstract class AppObserver
    {
        protected Subject subject;
        public abstract void Update();
    }
}
