using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Command
{
    public class BuyQuery : Order
    {
        private Query _query;
        public BuyQuery(Query query)
        {
            _query = query;
        }

        public abstract Order Order
        {
            get => default;
            set;
        }

        public void excecute()
        {
            _query.Buy();  //виконуємо команду покупки товару
        }
    }
}
