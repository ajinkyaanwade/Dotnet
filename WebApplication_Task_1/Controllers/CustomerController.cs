using Microsoft.AspNetCore.Mvc;
using WebApplication_Task_1.Models;

namespace WebApplication_Task_1.Controllers
{
    public class CustomerController: Controller
    {
        ICustomer _customerrp;
        public CustomerController(ICustomer customerrp)
        {
            _customerrp = customerrp;
        }
        public IActionResult Index() 
        {
            var customerList = _customerrp.GetAllCustomers();
            return View(customerList);
        }
    }
}
