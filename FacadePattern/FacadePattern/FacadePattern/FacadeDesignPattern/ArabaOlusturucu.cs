using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.FacadeDesignPattern
{
    class ArabaOlusturucu
    {
        public IskeletOlusturucu Iskelet { get; set; }

        public MotorOlusturucu Motor { get; set; }

        public ArabaOlusturucu(IskeletOlusturucu Iskelet , MotorOlusturucu Motor)
        {
            this.Iskelet = Iskelet;
            this.Motor = Motor;
        }

        public Araba Olustur(Renkler renk)
        {
            return new Araba(Iskelet, Motor, renk);
        }
    }
}
