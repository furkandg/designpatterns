using ObserverPattern.ObserverDesignPattern;
using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {


            Ogrenci o = new Ogrenci();
            o.AboneEkle(new BabaObserver());
            o.AboneEkle(new AnneObserver());
            o.AboneEkle(new OgretmenObserver());

            o.Adi = "Ahmet";
            o.Soyadi = "Yıldız";
            o.Memleket = "Denizli";
            o.Sinif = 3;
            o.DersAstimi = true;

            Console.ReadKey(true);
        }
    }
}
