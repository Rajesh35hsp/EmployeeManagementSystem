using Application;
using Domain;

namespace Infrastructure
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                {
                    new Employee()
                    {
                        Id = 1,
                        Name = "John",
                        Salary = 1000,
                        Age = 25
                    }
                },
                {
                    new Employee()
                    {
                        Id = 2,
                        Name = "Jane",
                        Salary = 2000,
                        Age = 30
                    }
                },
                {
                    new Employee()
                    {
                        Id = 3,
                        Name = "Doe",
                        Salary = 3000,
                        Age = 35
                    }
                }
            };
        }
    }
}
