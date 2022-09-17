using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Obsaever
{
    public class Subject
    {
        private List<AppObserver> observers = new List<AppObserver>();
        //private int state;
        private int state;

        public int State
        {
            get { return state; }
            set 
            { 
                state = value;
                notifyAllObservers();
            }
        }

        public void attach(AppObserver observer)
        {
            observers.Add(observer);
        }
        public void notifyAllObservers()
        {
            foreach (var item in observers)
            {
                item.Update();
            }
        }

    }
}
