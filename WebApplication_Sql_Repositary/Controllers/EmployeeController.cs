using Microsoft.AspNetCore.Mvc;
using WebApplication_Sql_Repositary.Models;

namespace WebApplication_Sql_Repositary.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        // GET: EmployeeController
        public ActionResult Index()
        {
            var model = _employeeRepository.GetAllEmployee();
            return View(model);
        }
        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            var model = _employeeRepository.GetEmployee(id);
            return View(model);
        }
        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            try
            {
                var model = _employeeRepository.Add(employee);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }

        }
        public ActionResult Edit(int id)
        {
            var model = _employeeRepository.GetEmployee(id);
            return View(model);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee emp)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var model = _employeeRepository.Update(emp);

                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            var model = _employeeRepository.GetEmployee(id);
            return View(model);

        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var model = _employeeRepository.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
