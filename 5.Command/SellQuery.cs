using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Command
{
    public class SellQuery : Order
    {
        private Query _query;

        public SellQuery(Query query)
        {
            _query = query;
        }

        public Order Order
        {
            get => default;
            set
            {
            }
        }

        public void excecute()
        {
            _query.Sell();
        }
    }
}
