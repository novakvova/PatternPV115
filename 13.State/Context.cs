using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.State
{
    public class Context
    {
        private AppState state;

        public Context()
        {
            state = null;
        }

        public void setState(AppState state)
        {
            this.state = state;
        }

        public AppState getState()
        {
            return state;
        }
    }
}
