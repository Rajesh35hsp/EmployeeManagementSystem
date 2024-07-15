using Application;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmsDbContext _emsDbContext;
        public EmployeeRepository(EmsDbContext emsDbContext)
        {
            _emsDbContext = emsDbContext;
        }
        public List<Employee> GetEmployees()
        {

            //var sss = _emsDbContext.Employees.ToList();

            //foreach (var item in sss)
            //{
            //    Console.WriteLine(item.Department.Name);
            //}


            //fetch emp and include department name
            var s = _emsDbContext.Employees.Include(e => e.Department).ToList();

            

            var ss = (from emp in _emsDbContext.Employees
                     join dept in _emsDbContext.Departments
                     on emp.DepartmentId equals dept.Id
                     select new
                     {
                         emp.Id,
                         emp.Name,
                         DepartmentName = dept.Name
                     }).ToList();

         

            return s;
        }
    }
}
