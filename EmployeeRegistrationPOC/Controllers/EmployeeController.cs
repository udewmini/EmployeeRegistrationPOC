using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EmployeeRegistrationPOC.Services;
using EmployeeRegistrationPOC.Models;
using Microsoft.AspNetCore.Cors;

namespace EmployeeRegistrationPOC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        private ILogger _logger;
        private IEmployeeService _service;


        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService service)
        {
            _logger = logger;
            _service = service;

        }

        [HttpGet("/api/employee")]
        public ActionResult<List<Employee>> GetEmployee()
        {
            return _service.GetEmployee();
        }

        [HttpPost("/api/employee")]
        public ActionResult<Employee> AddProduct(Employee employee)
        {
            _service.AddEmployee(employee);
            return employee;
        }

        [HttpPut("/api/employee/{id}")]
        public ActionResult<Employee> UpdateProduct(int id, Employee employee)
        {
            _service.UpdateEmployee(id, employee);
            return employee;
        }

        [HttpDelete("/api/employee/{id}")]
        public ActionResult<int> DeleteProduct(int id)
        {
            _service.DeleteEmployee(id);
            //_logger.LogInformation("products", _products);
            return id;
        }
    }
}
