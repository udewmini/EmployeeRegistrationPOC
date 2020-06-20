using EmployeeRegistrationPOC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EmployeeRegistrationPOC.Services
{
    public interface IEmployeeService
    {
        public List<Employee> GetEmployee();

        public Employee AddEmployee(Employee Emp);
        public Employee UpdateEmployee(int Id, Employee Emp);
        public int DeleteEmployee(int Id);
    }
}
