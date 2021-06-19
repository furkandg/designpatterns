using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_Pattern.Pattern
{
    public class CharacterA : Character
    {
        public CharacterA()
        {
            this.symbol = 'A';
            this.keyKod = 1;

        }
        public override void Display(int pointIndex)
        {
            this.pointIndex = pointIndex;
            Console.WriteLine(this.symbol + "(pointIndex"+this.pointIndex +")");
        }
    }
}
