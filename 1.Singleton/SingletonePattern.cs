using _1.Singleton.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Singleton
{
    public sealed class SingletonePattern
    {
        private static MyFileDatabase _instance=null;

        private SingletonePattern() { }

        public static MyFileDatabase GetInstance()
        {
            //if (_instance == null) { _instance = new MyFileDatabase(); }
            _instance ??= new MyFileDatabase();
            return _instance;
        }
    }
}
