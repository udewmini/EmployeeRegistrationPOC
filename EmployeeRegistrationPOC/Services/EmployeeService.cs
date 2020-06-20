using EmployeeRegistrationPOC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegistrationPOC.Services
{
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> _emp;

        public EmployeeService()
        {
            _emp = new List<Employee>();
        }

        public List<Employee> GetEmployee()
        {
            return _emp;
        }

        public Employee AddEmployee(Employee emp)
        {
            _emp.Add(emp);
            return emp;
        }

        public Employee UpdateEmployee(int Id, Employee emp)
        {
            for (var index = _emp.Count - 1; index >= 0; index--)
            {
                if (_emp[index].Id == Id)
                {
                    _emp[index] = emp;
                }
            }
            return emp;
        }

        public int DeleteEmployee(int id)
        {
            for (var index = _emp.Count - 1; index >= 0; index--)
            {
                if (_emp[index].Id == id)
                {
                    _emp.RemoveAt(index);
                }
            }

            return id;
        }
    }
}
