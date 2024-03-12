using Eterna_MVC_ConnectionDBcontext_task2.DAL;
using Eterna_MVC_ConnectionDBcontext_task2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;

namespace Eterna_MVC_ConnectionDBcontext_task2.Areas.Admin.Controllers
{
    [Area("admin")]
    public class ProductController : Controller
    {
        private readonly EternaDbContext _context;
        public ProductController(EternaDbContext context)
        {
            _context = context;
        }
        public async Task <IActionResult> Index()
        {
            List <Product>products= await _context.Products.Include(p=>p.Images).Include(p=>p.Category).ToListAsync();
            return View(products);
        }
        public async Task <IActionResult> Create()
        {
            ViewBag.Categories=await _context.Categories.ToListAsync();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Create(Product product)
        {
            ViewBag.Categories = await _context.Categories.ToListAsync();
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (await _context.Products.AnyAsync(p => p.Name.ToLower() == product.Name.ToLower()))
            {
                ModelState.AddModelError("name", "Already Product name is exist");
                return View();
            }
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task <IActionResult> Update(int id)
        {
            ViewBag.Categories = await _context.Categories.ToListAsync();
            Product product= await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
            if (product == null) throw new NullReferenceException();
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Product product)
        {
            ViewBag.Categories = await _context.Categories.ToListAsync();
            Product currentProduct= await _context.Products.FirstOrDefaultAsync(p=>p.Id == product.Id);
            if(!ModelState.IsValid)
            {
                return View();
            }
            if((await _context.Products.AnyAsync(p=>p.Name.ToLower() == product.Name.ToLower()))&& (currentProduct.Name.ToLower()!=product.Name.ToLower()))
            {
                ModelState.AddModelError("Name", "Already Product name is exist");
                return View();
            }
            currentProduct.Name= product.Name;
            currentProduct.Description= product.Description;
            currentProduct.CategoryId= product.CategoryId;
            currentProduct.Client= product.Client;
            currentProduct.Title= product.Title;
            currentProduct.ProjectUrl= product.ProjectUrl;
            await _context.SaveChangesAsync();
            return RedirectToAction("index");
        }
        public async Task <IActionResult> Delete(int id)
        {
            Product product= await _context.Products.FirstOrDefaultAsync(p=>p.Id==id);
            if (product == null) return NotFound();
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
