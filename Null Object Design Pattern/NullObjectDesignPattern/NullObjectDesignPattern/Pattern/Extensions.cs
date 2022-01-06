using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectDesignPattern.Pattern
{
    static class Extensions
    {
        public static AbstractEmployee NullCheck(this AbstractEmployee instance)
            => instance ?? NullEmployee.Nil;
    }
}
