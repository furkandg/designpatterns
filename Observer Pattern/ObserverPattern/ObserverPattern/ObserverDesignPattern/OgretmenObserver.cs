using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.ObserverDesignPattern
{
    public class OgretmenObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Öğretmenin Haberi Oldu");
        }
    }
}
