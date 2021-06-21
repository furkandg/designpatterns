using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Patter.Classes
{
    public class Buzdolabi : Alisveris
    {
        public override void OdemeSekli()
        {
            odemeTipi = OdemeTipi.Taksit;
        }

        public override void Urun()
        {
            UrunAdi = "Buzdolabı";
        }
    }
}
