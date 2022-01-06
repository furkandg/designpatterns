using NullObjectDesignPattern.Pattern;
using System;

namespace NullObjectDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeService employeeService = new EmployeeService(new EmployeeRepository());
            AbstractEmployee e = employeeService.GetEmployeeByName("Ahmet");
            e.GetFullName();
            e = employeeService.GetEmployeeByName("Mehmet");
            e.GetFullName();
            e = employeeService.GetEmployeeByName("Mahmut");
            e.GetFullName();
        }
    }
}
