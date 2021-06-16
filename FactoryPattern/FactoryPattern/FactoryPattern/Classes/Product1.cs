using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Classes
{
    public class Product1 : IProduct
    {
        public string siparisFormu()
        {
            return "İstanbul'dan Gelen Ürünler";
        }
    }
}
