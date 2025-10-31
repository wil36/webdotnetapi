using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [Route("employees/all")]
        public string GetAllEmployees()
        {
            return "All Employees List";
        }
        [Route("employees/{id:int}")]
        public string GetEmployeeById(int id)
        {
            return "Employee Details by Id = " + id;
        }

        [Route("{id}")]
        public string GetEmployeeDetails(int id)
        {
            return "Employee Details by Id = " + id;
        }

        [Route("{name:alpha}")]
        public string GetEmployeeDetails(string name)
        {
            return "Employee Details by Id = " + name;
        }
    }
}
