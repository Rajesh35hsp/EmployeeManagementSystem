using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IEmployeeService
    {
        //void AddEmployee(string name, int salary, int age);
        //void DeleteEmployee(int id);
        //void UpdateEmployee(int id, string name, int salary, int age);
        List<Employee> GetEmployees();
    }
}
