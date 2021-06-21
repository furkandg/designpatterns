using System;

namespace Template_Patter
{
    class Program
    {
        static void Main(string[] args)
        {

            Classes.Alisveris a1 = new Classes.Buzdolabi();

            a1.TemplateMethod();

            Console.WriteLine("************************");

            Classes.Alisveris a2 = new Classes.Televizyon();

            a2.TemplateMethod();

        }
    }
}
