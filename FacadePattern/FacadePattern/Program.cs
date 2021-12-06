using FacadePattern.FacadeDesignPattern;
using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FacadeUretici uretici = new FacadeUretici();
            uretici.ArabaUret();
            Console.ReadKey();
        }
    }
}
