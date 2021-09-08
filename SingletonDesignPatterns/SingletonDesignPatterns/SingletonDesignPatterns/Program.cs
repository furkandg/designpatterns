using SingletonDesignPatterns.SingletonDesignPattern;
using System;

namespace SingletonDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            DbHelper ilk = DbHelper.CreateDbHelper("Oluşturuldu");
            ilk.StateMessage = "Aşama 1";
            Console.WriteLine(ilk.StateMessage);

            DbHelper iki = DbHelper.CreateDbHelper("Bağlantı");


            Console.WriteLine(iki.StateMessage);
        }
    }
}
