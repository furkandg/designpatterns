using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_Pattern.Pattern
{
    public class CharacterB:Character
    {
        public CharacterB()
        {
            this.symbol = 'B';
            this.keyKod = 2;

        }
        public override void Display(int pointIndex)
        {
            this.pointIndex = pointIndex;
            Console.WriteLine(this.symbol + "(pointIndex" + this.pointIndex + ")");
        }
    }
}
