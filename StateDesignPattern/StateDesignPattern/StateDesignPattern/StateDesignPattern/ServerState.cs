using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern.StateDesignPattern
{
     abstract internal class ServerState
    {
        public abstract void HandleState(Server context);
    }
}
