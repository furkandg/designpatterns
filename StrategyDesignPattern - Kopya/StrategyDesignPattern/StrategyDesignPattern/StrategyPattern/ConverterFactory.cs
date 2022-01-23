using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.StrategyPattern
{
    internal static class ConverterFactory
    {
        public static IStrategy CreateConverterClass(string choice)
        {
            IStrategy selectedStrategy = null;
            if (choice == "mp3")
            {
                selectedStrategy = new Mp3Converter();
            }
            else if (choice =="wma")
            {
                selectedStrategy = new WMAConverter();
            }
            return selectedStrategy;
        }
    }
}
