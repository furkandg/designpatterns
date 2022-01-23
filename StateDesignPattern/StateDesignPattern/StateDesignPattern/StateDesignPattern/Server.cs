using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern.StateDesignPattern
{
    internal class Server
    {
        public int CPULevel { get; set; }

        private ServerState _state;

        public ServerState State
        {
            get { return _state; }
            set { 
                _state = value;
                _state.HandleState(this);
            }
        }
        public Server()
        {
            this.CPULevel = 50;
            ControlServerCPULevel();
        }
                                     
        public void ControlServerCPULevel()
        {
            if (this.CPULevel > 80)
            {
                this.State = new OverloadState();
            }
            else this.State = new OkState();
        }

        public void CloseProgram (int programUsageCPU)
        {
            this.CPULevel -= programUsageCPU;
        }

        public void AddProgram(int programUsageCPU) {
            this.CPULevel += programUsageCPU;
            ControlServerCPULevel(); 
        } 

    }
}
