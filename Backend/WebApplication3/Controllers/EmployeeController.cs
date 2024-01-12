using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly AppDBContext _appDbContext;


        public EmployeeController(AppDBContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        [HttpGet]
        [Route("GetEmployee")]
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _appDbContext.Employee.ToListAsync();


        }

        [HttpPost]

        [Route("AddEmployee")]

        public async Task<Employee> AddDepartment(Employee objEmployee)
        {
            _appDbContext.Employee.Add(objEmployee);
            await _appDbContext.SaveChangesAsync();
            return objEmployee;

        }

        [HttpPatch]

        [Route("UpdateEmployee/{id}")]

        public async Task<Employee> UpdateDepartment(Employee objEmployee)
        {
            _appDbContext.Entry(objEmployee).State = EntityState.Modified;
            await _appDbContext.SaveChangesAsync();
            return objEmployee;
        }

        [HttpDelete]
        [Route("DeleteEmployee/{id}")]

        public bool DeleteEmployee(int id)
        {
            bool a = false;
            var Employee = _appDbContext.Employee.Find(id);

            if (Employee != null)
            {
                a = true;
                _appDbContext.Entry(Employee).State = EntityState.Deleted;
                _appDbContext.SaveChanges();

            }

            else
            {
                a = false;

            }
            return a;
        }


    }
}


    

