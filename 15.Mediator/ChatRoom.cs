using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Mediator
{
    public class ChatRoom
    {
        public static void showMessage(User user, String message)
        {
            Console.WriteLine(DateTime.Now + " [" + user.getName() + "] : " + message);
        }
    }
}
