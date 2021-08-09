using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.ObserverDesignPattern
{
    public class AnneObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Annesinin Haberi Oldu");
        }
    }
}
