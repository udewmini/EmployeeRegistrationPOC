using EmployeeRegistrationPOC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegistrationPOC.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly Context _context;
        // private List<Employee> _emp;

        public EmployeeService()
        {
            _context = new Context();
            // _emp = new List<Employee>();
        }

        public List<Employee> GetEmployee()
        {
            return _context.Employee.OrderBy(p => p.Id).ToList();
            //return _emp;
        }

        public Employee AddEmployee(Employee emp)
        {
            _context.Employee.Add(emp);
            _context.SaveChanges();
            return emp;
        }

        public async Task<Employee> UpdateEmployee(int Id, Employee emp)
        {
           
            var employeeItem = await _context.Employee.FindAsync(Id);
            if (employeeItem != null)
            {
                employeeItem.Fname = emp.Fname;
                employeeItem.Lname = emp.Lname;
                employeeItem.Position = emp.Position;
                employeeItem.Email = emp.Email;
                employeeItem.Address = emp.Address;
                employeeItem.Contact = emp.Contact;
               

            }

            await _context.SaveChangesAsync();
            return employeeItem;

        }

        public async Task<int> DeleteEmployee(int id)
        {
            for (var index = _context.Employee.Count() - 1; index >= 0; index--)
            {
                if (_context.Employee.ToArray()[index].Id == id)
                {
                    _context.Employee.Remove(_context.Employee.ToArray()[index]);
                }
            }

            await _context.SaveChangesAsync();
            return id;
        }
    }
}
