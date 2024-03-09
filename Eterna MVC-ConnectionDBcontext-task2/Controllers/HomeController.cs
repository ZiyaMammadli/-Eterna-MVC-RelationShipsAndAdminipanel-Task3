using Eterna_MVC_ConnectionDBcontext_task2.DAL;
using Eterna_MVC_ConnectionDBcontext_task2.Models;
using Eterna_MVC_ConnectionDBcontext_task2.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Eterna_MVC_ConnectionDBcontext_task2.Controllers
{
    public class HomeController : Controller
    {
        private readonly EternaDbContext _context;
        public HomeController(EternaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<Slider> sliders=_context.Sliders.ToList();
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                features = _context.Featureds.ToList(),
                sliders = sliders,
                about= _context.Abouts.ToList(),
                services = _context.Services.ToList(),
                clients = _context.Clients.ToList(),
            };
            ViewData["title"] = "Sponsorlar";
            ViewData["desc"] = "Biz sirket olafraq emekdasliqa diqqet gosteririk bizi secen sponsorlar asagidakilardir";
            return View(homeViewModel);
        }
    }
}
