using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectDesignPattern.Pattern
{
    abstract public class AbstractEmployee
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract string Surname { get; set; }
        public abstract void GetFullName();

    }
}
