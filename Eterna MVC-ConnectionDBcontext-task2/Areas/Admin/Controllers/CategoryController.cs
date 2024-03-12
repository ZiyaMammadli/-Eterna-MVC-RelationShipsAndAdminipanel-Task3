using Eterna_MVC_ConnectionDBcontext_task2.DAL;
using Eterna_MVC_ConnectionDBcontext_task2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Eterna_MVC_ConnectionDBcontext_task2.Areas.Admin.Controllers
{
    [Area("admin")]
    public class CategoryController : Controller
    {
       
        private readonly EternaDbContext _context;
        public CategoryController(EternaDbContext context)
        {
            _context = context;
        }
        
        public async Task <IActionResult> Index()
        {
          List <Category> categories = await _context.Categories.ToListAsync();
            return View(categories);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid) return View();
            if(await _context.Categories.FirstOrDefaultAsync(c => c.Name.ToLower() == category.Name.ToLower()) != null)
            {
                ModelState.AddModelError("Name", "Already is exist");
                return View();
            }
           await _context.Categories.AddAsync(category);
           await _context.SaveChangesAsync();
            return RedirectToAction("index");
        }
        public async Task <IActionResult> Update(int id)
        {
           Category category= await _context.Categories.FindAsync(id);
            if(category == null) throw new NullReferenceException();
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Update(Category category)
        {
            

            Category currentCategory = await _context.Categories.FirstOrDefaultAsync(c=>c.Id == category.Id);
            if(currentCategory == null) throw new NullReferenceException();
            if (!ModelState.IsValid) return View();
            if(await _context.Categories.AnyAsync(c=>c.Name.ToLower() == category.Name.ToLower()) && (currentCategory.Name.ToLower() != category.Name.ToLower()))
            {
                ModelState.AddModelError("Name", "Already is exist");
                return View();
            }
            currentCategory.Name = category.Name;
            await _context.SaveChangesAsync();
            return RedirectToAction("index");
        }
        public async Task <IActionResult> Delete(int id)
        {
            Category category=await _context.Categories.FindAsync(id);
            if(category == null) return NotFound();
             _context.Remove(category);
            _context.SaveChanges();
            return Ok();
        }
    }
}
