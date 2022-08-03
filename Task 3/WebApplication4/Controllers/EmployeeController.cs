using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class EmployeeController : Controller
    {

        IEmployee _employee;

        public EmployeeController(IEmployee employee) 
        {
            _employee = employee;   
        }
        
        public IActionResult Index()
        {
            IEnumerable<employee> empList =  _employee.getAllEmployees();
            return View(empList);
        }

        public IActionResult Details(int id) 
        {
            employee obj = _employee.getEmployeeById(id);
            return View(obj);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(employee obj)
        {
            _employee.createEmployee(obj);
            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult Edit(int id) 
        {
            employee obj = _employee.getEmployeeById(id);
            return View(obj);
        }

        [HttpPost]

        public IActionResult Edit(employee obj)
        {
            _employee.updateEmployee(obj);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id) 
        {
            employee obj = _employee.getEmployeeById(id);
            return View(obj);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteEmp(int id)
        {
            _employee.deleteEmployee(id);
            return RedirectToAction("Index");
        }



    }
}
