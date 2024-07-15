using Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService) 
        {
            this._employeeService = employeeService;
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetEmployees()
        {
            return Ok(_employeeService.GetEmployees());
        }
    }
}
