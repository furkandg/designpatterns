using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectDesignPattern.Pattern
{
     class NullEmployee : AbstractEmployee
    {
        private NullEmployee() { }
        static NullEmployee nullEmployee;
        public static NullEmployee Nil => nullEmployee ?? (nullEmployee = new NullEmployee());

        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Surname { get; set; }
        public override void GetFullName()
            => Console.WriteLine("Employee not found!");
        
    }
}
