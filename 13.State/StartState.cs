using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.State
{
    public class StartState : AppState
    {
        public void doAction(Context context)
        {
            Console.WriteLine("Запуск автомобіля");
            context.setState(this);
        }

        public override string ToString()
        {
            return "Автомобіль запущено";
        }
    }
}
