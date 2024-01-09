using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly AppDBContext _appDbContext;


        public DepartmentController(AppDBContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        [HttpGet]
        [Route("GetDepartment")]
        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await _appDbContext.Departments.ToListAsync();


        }

        [HttpPost]

        [Route("AddDepartment")]

        public async Task<Department> AddDepartment(Department objDepartment) 
        {
            _appDbContext.Departments.Add(objDepartment);
            await _appDbContext.SaveChangesAsync();
            return objDepartment;

        }

        [HttpPatch]

        [Route("UpdateDepartment/{id}")]

        public async Task<Department> UpdateDepartment(Department objDepartment)
        {
            _appDbContext.Entry(objDepartment).State = EntityState.Modified;
            await _appDbContext.SaveChangesAsync();
            return objDepartment;
        }

        [HttpDelete]
        [Route("DeleteDepartment/{id}")]

        public bool DeleteDepartment(int id) 
        {
            bool a = false;
            var Department = _appDbContext.Departments.Find(id);

            if (Department != null) 
            {
                a= true; 
                _appDbContext.Entry(Department).State = EntityState.Deleted;
                _appDbContext.SaveChanges();

            }

            else
            {
                a= false;

            }
            return a;   
        }


    }
}
