
using Microsoft.AspNetCore.Mvc;

namespace BasicApplication.Controllers
{
    [Route("products")]
    public class ProductsController :Controller
    {
        [Route("")] // Combines to define the route 'products' 

        public IActionResult Index()

        {

            return View();

        }



        [Route("{id}")] // Combines to define the route 'products/id' 
        public IActionResult Details(int id)
        {
            return View();
        }

    }
}
