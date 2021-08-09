using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.ObserverDesignPattern
{
    public class Ogrenci
    {
        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public string Memleket { get; set; }

        public int Sinif { get; set; }

        bool dersAstimi;

        public bool DersAstimi {

            get { return dersAstimi; }
            
            set
            {
                if (value==true)
                {
                    Notify();
                    dersAstimi = value;

                }
                else
                {
                    dersAstimi = value;
                }
            }
        
        
        }

        List<Observer> Gozlemciler;

        public Ogrenci()
        {
            this.Gozlemciler = new List<Observer>();
        }

        public void AboneEkle(Observer observer)
        {
            Gozlemciler.Add(observer);
        }

        public void AboneCikar(Observer observer)
        {
            Gozlemciler.Remove(observer);
        }
        public void Notify()
        {
            Gozlemciler.ForEach(g => { g.Update();});
        }
    }
}
