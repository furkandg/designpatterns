using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesingPattern.ProxyDesignPattern
{
    internal class ProxyBanka : IBanka
    {
        Banka banka;
        bool Login;
        string KullaniciAdi, Sifre;

        public ProxyBanka(string KullaniciAdi, string Sifre)
        {
            this.KullaniciAdi = KullaniciAdi;
            this.Sifre = Sifre;
        }
        public bool GirisYap()
        {
            if (KullaniciAdi.Equals("nano") && Sifre.Equals("1234"))
            {
                banka = new Banka();
                Login = true;
                Console.WriteLine("Hesaba Giriş Yapıldı");
                return true;
            }
            else Console.WriteLine("Giriş Bilgilerinizden emin olunuz");
            Login = false;
            return false;
        }

        public bool OdemeYap(double Tutar)
        {
            GirisYap();
            if (!Login)
            {
                Console.WriteLine("Hesaba Giriş Yapılamadığı için ödeme alamıyoruz.");
                return false;
            }
            banka.OdemeYap(Tutar);
            return true; 
        }

    }
}
