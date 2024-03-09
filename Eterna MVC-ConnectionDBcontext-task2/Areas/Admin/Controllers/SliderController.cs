using Eterna_MVC_ConnectionDBcontext_task2.DAL;
using Eterna_MVC_ConnectionDBcontext_task2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eterna_MVC_ConnectionDBcontext_task2.Areas.Admin.Controllers
{
    [Area("admin")]
    public class SliderController : Controller
    {
        private readonly EternaDbContext _context;
        public SliderController(EternaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            return View(sliders);
        }
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(Slider slider) 
        {
            _context.Sliders.Add(slider);
            _context.SaveChanges();
            return RedirectToAction("Index");   
        }
        public IActionResult Update(int id)
        {
            Slider? slider = _context.Sliders.FirstOrDefault(x => x.Id == id);
            if (slider == null) throw new NullReferenceException("yanlis referans");
            return View(slider);
        }
        [HttpPost]
        public IActionResult Update(Slider slider)
        {
            Slider CurrentSlider= _context.Sliders.FirstOrDefault(s=>s.Id == slider.Id);
            if (slider == null) throw new NullReferenceException("yanlis referans");
            CurrentSlider.Title1=slider.Title1;
            CurrentSlider.Title2=slider.Title2;
            CurrentSlider.Desc=slider.Desc;
            CurrentSlider.image=slider.image;
            CurrentSlider.Url=slider.Url;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            Slider slider = _context.Sliders.FirstOrDefault(s=>s.Id == id);
            _context.Sliders.Remove(slider);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
