using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace EmployeeRegistrationPOC.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Position { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }

    }
}
