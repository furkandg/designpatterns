using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_Pattern.Pattern
{
    public class CharacterZ : Character
    {
        public CharacterZ()
        {
            this.symbol = 'Z';
            this.keyKod = 29;
         }
        public override void Display(int pointIndex)
        {
            this.pointIndex = pointIndex;
            Console.WriteLine(this.symbol + "(pointIndex" + this.pointIndex + ")");
        }
    }
}
