using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern.StateDesignPattern
{
    internal class OverloadState : ServerState
    {
        public override void HandleState(Server context)
        {
            Console.WriteLine(@"Server CPULevel is :{0}. Server state is overload. Some programs is closing.", context.CPULevel);
            context.CloseProgram(5);
            if (context.CPULevel > 80)
            {
                context.State = new OverloadState();
            }
            else context.State = new OkState();
        }
    }
}
