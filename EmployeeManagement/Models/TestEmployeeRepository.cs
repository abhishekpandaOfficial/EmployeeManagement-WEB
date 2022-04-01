using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Models
{
    public class TestEmployeeRepository : IEmployeeRepository
    {
        public void AddEmployee(Employee employee)
        {
            throw new System.NotImplementedException();
        }

        public List<Employee> DataSource()
        {
            return new List<Employee>()
            {
                new Employee(){ EmpID = 1, EmpName ="Abhishek", Gender="M", Role="FullStack Developer" },
                 new Employee(){ EmpID = 2, EmpName ="Sumit", Gender="M", Role="Automation Engineer" },
                  new Employee(){ EmpID = 3, EmpName ="Biku", Gender="M", Role="Tester" },
                  new Employee(){ EmpID = 4, EmpName ="Manisha", Gender="F", Role="Azure Admin" },
                  new Employee(){ EmpID = 5, EmpName ="Namrata", Gender="F", Role="AWS Developer" }
            };
        }

        public void DeleteEmployee(int Empid)
        {
            throw new System.NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            return DataSource().ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return DataSource().FirstOrDefault(e => e.EmpID == id);
        }

        public void UpdateEmployee(Employee employee)
        {
            throw new System.NotImplementedException();
        }
    }
}
