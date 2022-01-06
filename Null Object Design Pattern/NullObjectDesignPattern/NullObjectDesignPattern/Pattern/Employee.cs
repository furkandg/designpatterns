using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectDesignPattern.Pattern
{
    public class Employee : AbstractEmployee
    {
        public override int Id {get;set;}
        public override string Name { get; set; }
        public override string Surname { get; set; }

        public override void GetFullName() => Console.WriteLine($"{Name} {Surname}");
        
    }
}
