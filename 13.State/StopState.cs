using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.State
{
    public class StopState : AppState
    {
        public void doAction(Context context)
        {
            Console.WriteLine("Зупинка автомобіля");
            context.setState(this);
        }

        public override string ToString()
        {
            return "Автомобіль зупинився";
        }
    }
}
