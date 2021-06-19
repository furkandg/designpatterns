using FactoryPattern.Classes;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Creator c = new Creator();
            IProduct product = c.FactoryMethod(ProductType.Product1);

            Console.WriteLine(product.siparisFormu());
        }
    }
}
