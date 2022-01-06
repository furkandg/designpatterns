using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullObjectDesignPattern.Pattern
{
    class EmployeeRepository
    {
        List<AbstractEmployee> employeeList = new List<AbstractEmployee> {
        new Employee(){Id=1,Name="Ahmet",Surname="Yıldız"},
        new Employee(){Id=2,Name="Mehmet",Surname="Yıldırım"},
        new Employee(){Id=3,Name="Hasan",Surname="Demir"},
        };

        public List<AbstractEmployee> GetWhere(Func<AbstractEmployee, bool> method) => employeeList.Where(method).ToList();
        public AbstractEmployee GetSingle(Func<AbstractEmployee, bool> method) => employeeList.FirstOrDefault(method);

    }
}
