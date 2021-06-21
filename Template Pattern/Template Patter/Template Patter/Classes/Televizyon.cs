using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Patter.Classes
{
    public class Televizyon : Alisveris
    {
        public override void OdemeSekli()
        {
            odemeTipi = OdemeTipi.Pesin;
        }

        public override void Urun()
        {
            UrunAdi = "Televizyon";
        }
    }
}
