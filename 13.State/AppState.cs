using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.State
{
    public interface AppState
    {
        public void doAction(Context context);
    }
}
