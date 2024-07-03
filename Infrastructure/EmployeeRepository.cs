using Application;
using Domain;

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
            var s = _emsDbContext.Employees.ToList();
            return s;
        }
    }
}
