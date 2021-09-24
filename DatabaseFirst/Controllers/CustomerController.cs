using DatabaseFirst.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseFirst.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public  async Task<IActionResult> ListadoClientes()
        {
            var customers = await CustomerRepo.GetCustomerAsync();
            return PartialView(customers);
        }
    }
}
