using DatabaseFirst.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseFirst.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ListadoProductos()
        {
            var product = await ProductRepo.GetProductAsync();
            return PartialView(product);
        }



        /*
                [HttpPost]
                public async Task<IActionResult> Eliminar(int idProduct)
                {
                    var exito = await ProductRepo.Delate(idProduct);
                    return Json(exito);
                }
        */
    }

}
