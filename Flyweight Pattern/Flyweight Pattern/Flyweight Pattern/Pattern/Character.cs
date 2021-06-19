using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_Pattern.Pattern
{
    public abstract class Character
    {
        protected char symbol;
        protected int keyKod;
        protected int pointIndex;

        public abstract void Display(int pointIndex);

    }
}
