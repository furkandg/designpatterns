using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.ObserverDesignPattern
{
    public class BabaObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Öğrencinin kaçtığından babasının haberi oldu.");
        }
    }
}
