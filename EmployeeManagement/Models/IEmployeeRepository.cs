using System.Collections.Generic;

namespace EmployeeManagement.Models
{
    public interface IEmployeeRepository   
    {
        List<Employee> GetAll();
        Employee GetEmployeeById(int Empid);
        void DeleteEmployee(int Empid);
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
    }
}
