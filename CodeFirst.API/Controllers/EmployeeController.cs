using System.Collections.Generic;
using CodeFirst.Models;
using CodeFirst.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst.API.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IDataRepository<Employee> _dataRepository;

        public EmployeeController(IDataRepository<Employee> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/Employee
        [HttpGet]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult Get()
        {
            IEnumerable<Employee> employees = _dataRepository.GetAll();
            return Ok(employees);
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult Get(long id)
        {
            Employee employee = _dataRepository.Get(id);

            if (employee == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }

            return Ok(employee);
        }

        // POST: api/Employee
        [HttpPost]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult Post([FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Employee is null.");
            }

            _dataRepository.Add(employee);
            return CreatedAtRoute(
                  "Get",
                  new { Id = employee.EmployeeId },
                  employee);
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult Put(long id, [FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Employee is null.");
            }

            Employee employeeToUpdate = _dataRepository.Get(id);
            if (employeeToUpdate == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }

            _dataRepository.Update(employeeToUpdate, employee);
            return NoContent();
        }

        // DELETE: api/Employee/5
        [HttpDelete("{id}")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult Delete(long id)
        {
            Employee employee = _dataRepository.Get(id);
            if (employee == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }

            _dataRepository.Delete(employee);
            return NoContent();
        }
    }
}