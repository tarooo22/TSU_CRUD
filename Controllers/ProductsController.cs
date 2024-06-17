using Microsoft.AspNetCore.Mvc;

namespace TSU_CRUD.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
