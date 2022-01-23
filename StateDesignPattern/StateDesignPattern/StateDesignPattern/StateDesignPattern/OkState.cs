using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern.StateDesignPattern
{
    internal class OkState : ServerState
    {
        public override void HandleState(Server context)
        {
            Console.WriteLine(@"Server CPULevel is:{0}. Server state is OK", context.CPULevel);
        }
    }
}
