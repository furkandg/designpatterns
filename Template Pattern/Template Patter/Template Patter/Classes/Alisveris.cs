using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Patter.Classes
{
    public abstract class Alisveris
    {

        protected string UrunAdi;

        protected OdemeTipi odemeTipi;
        void Baslat() => Console.WriteLine("Alışveriş Başladı");

        void Bitir() => Console.WriteLine($"Alışveri Bitti.{UrunAdi} {odemeTipi} yöntemiyle alınmıştır");

        abstract public void Urun();

        abstract public void OdemeSekli();

        public void TemplateMethod()
        {

            Baslat();
            Urun();
            OdemeSekli();
            Bitir();
        }

    }
}
