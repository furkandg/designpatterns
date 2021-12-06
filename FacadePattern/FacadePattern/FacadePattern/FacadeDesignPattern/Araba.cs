using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.FacadeDesignPattern
{
    class Araba
    {
        public Araba(IskeletOlusturucu Iskelet, MotorOlusturucu Motor, Renkler Renk)
        {
            Console.WriteLine($"Isketlet x={Iskelet.x}");
            Console.WriteLine($"Isketlet y={Iskelet.y}");
            Console.WriteLine($"Isketlet z={Iskelet.z}");
            Console.WriteLine($"Motor x={Motor.x}");
            Console.WriteLine($"Motor y={Motor.y}");
            Console.WriteLine($"Motor z={Motor.z}");
            Console.WriteLine($"Renk z={Renk}");
        }
    }
}
