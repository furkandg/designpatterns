using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.FacadeDesignPattern
{
    class FacadeUretici
    {
        IskeletOlusturucu iskelet;
        MotorOlusturucu motor;
        ArabaOlusturucu olustur;

        public FacadeUretici()
        {
            iskelet = new IskeletOlusturucu() { x = 3, y = 5, z = true };
            motor= new MotorOlusturucu() { x = 2, y = 4, z = false };
            olustur = new ArabaOlusturucu(iskelet, motor);

        }

        public void ArabaUret()
        {
            Araba uretilenAraba = olustur.Olustur(Renkler.Kırmızı);
        }
    }
}
