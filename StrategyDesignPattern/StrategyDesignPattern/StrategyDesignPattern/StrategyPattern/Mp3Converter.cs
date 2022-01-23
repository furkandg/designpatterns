using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.StrategyPattern
{
    internal class Mp3Converter : IStrategy
    {
        public void Convert()
        {
            Console.WriteLine("MP3 cevrim islemleri");
        }
    }
}
