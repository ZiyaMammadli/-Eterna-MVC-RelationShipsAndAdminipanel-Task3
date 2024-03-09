using Microsoft.AspNetCore.Mvc;

namespace Eterna_MVC_ConnectionDBcontext_task2.Areas.Admin.Controllers
{
    [Area("admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
