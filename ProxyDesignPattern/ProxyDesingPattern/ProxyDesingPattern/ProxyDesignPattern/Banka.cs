using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesingPattern.ProxyDesignPattern
{
    internal class Banka : IBanka
    {
        public bool OdemeYap(double Tutar)
        {
            if (Tutar <100)
            {
                Console.WriteLine($"Ödeyeceğiniz tutar 100 Tl'den daha az olamaz. Fark -> {100 - Tutar}");
            }
            else if (Tutar > 100)
            {
                Console.WriteLine($"ÖDeyeceğini< tutar 100 Tl'den fazla olamaz. Fark -> {Tutar - 100}");
            }
            else
            {
                Console.WriteLine($"Ödeme başarıyla gerçekleştirild. -> {Tutar}");
                return true;
            }

            return false;

        }

    }
}
