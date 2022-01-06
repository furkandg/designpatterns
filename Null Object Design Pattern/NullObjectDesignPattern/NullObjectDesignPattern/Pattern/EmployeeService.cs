using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectDesignPattern.Pattern
{
    class EmployeeService
    {
        readonly EmployeeRepository _employeeRepository;
        public EmployeeService(EmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public AbstractEmployee GetEmployeeByName(string name)
        {
           return _employeeRepository.GetSingle(x => x.Name == name).NullCheck();
        }
    }
}
