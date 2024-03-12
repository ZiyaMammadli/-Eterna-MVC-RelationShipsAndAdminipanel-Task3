using Eterna_MVC_ConnectionDBcontext_task2.DAL;
using Eterna_MVC_ConnectionDBcontext_task2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eterna_MVC_ConnectionDBcontext_task2.Areas.Admin.Controllers
{
    [Area("admin")]
    public class FeaturedController : Controller
    {
        private readonly EternaDbContext _context;
        public FeaturedController(EternaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
          List< Featured> featureds= _context.Featureds.ToList();
            return View(featureds);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Featured featured)
        {
            _context.Featureds.Add(featured);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Update(int id)
        {
            Featured featured=_context.Featureds.FirstOrDefault(x => x.Id == id);
            return View(featured);
        }
        [HttpPost]
        public IActionResult Update(Featured featured)
        {
            Featured CurrentFeatured=_context.Featureds.FirstOrDefault(f=>f.Id==featured.Id);
            CurrentFeatured.Icon=featured.Icon;
            CurrentFeatured.Title=featured.Title;
            CurrentFeatured.Description=featured.Description;
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Delete(int id)
        {
            Featured featured=_context.Featureds.FirstOrDefault(f => f.Id==id);
            _context.Featureds.Remove(featured);
            return RedirectToAction("index");
        }

    }
}
