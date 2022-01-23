using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.StrategyPattern
{
    internal class WMAConverter : IStrategy
    {
        public void Convert()
        {
            Console.WriteLine("WMA cevrim islemleri");
        }
    }
}
