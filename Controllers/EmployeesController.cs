using Microsoft.AspNetCore.Mvc;

namespace TSU_CRUD.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
