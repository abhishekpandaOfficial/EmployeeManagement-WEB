using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeRepository _employeeRepository = null;

        public HomeController(ILogger<HomeController> logger , IEmployeeRepository employeeRepository)
        {
            _logger = logger;
            _employeeRepository = employeeRepository;
        }
        // Without Dependency Injection Implementation 
        public JsonResult GetEmployeeDetailsById(int id)
        {
            //+++++++++++++ Without Dependency Injection Implementation ++++++++++++
            //TestEmployeeRepository repository = new TestEmployeeRepository();
            //Employee emp = repository.GetEmployeeById(id);
            //return Json(emp);

            //+++++++++++++ WITH Dependency Injection Implementation ++++++++++++

            Employee employees = _employeeRepository.GetEmployeeById(id);
            return Json(employees);
        }

        public JsonResult GetEmployeeDetails()
        {
            //+++++++++++++ Without Dependency Injection Implementation ++++++++++++ 

            //TestEmployeeRepository repository = new TestEmployeeRepository();
            //List<Employee> emp = repository.GetAll();
            //return Json(emp);

            //+++++++++++++ WITH Dependency Injection Implementation ++++++++++++
            List<Employee> emps = _employeeRepository.GetAll();
            return Json(emps);
        }

        public IActionResult Index()
        {
            return View();
        }
       

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
