// See https://aka.ms/new-console-template for more information
using ProxyDesingPattern.ProxyDesignPattern;

string KullaniciAdi = "", Sifre = "";
double Tutar = 0;
while (true)
{
    Console.WriteLine("Lütfen Kullanıcı adınızı Giriniz.");
    KullaniciAdi = Console.ReadLine();

    Console.WriteLine("Lütfen Şifrenizi Giriniz");
    Sifre = Console.ReadLine();

    Console.WriteLine("Lütfen Ödenecek Tutarı Giriniz.");
    Tutar = Convert.ToInt32(Console.ReadLine());

    IBanka banka = new ProxyBanka(KullaniciAdi, Sifre);
    banka.OdemeYap(Tutar);
    Console.WriteLine("****************");
    Console.ReadKey();
}