using Eterna_MVC_ConnectionDBcontext_task2.DAL;
using Eterna_MVC_ConnectionDBcontext_task2.Models;
using Eterna_MVC_ConnectionDBcontext_task2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eterna_MVC_ConnectionDBcontext_task2.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly EternaDbContext _context;
        public PortfolioController(EternaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            PortfolioViewModel portfolioViewModel = new PortfolioViewModel()
            {
                clients=_context.Clients.ToList(),
                categories=_context.Categories.ToList(),
                productsImages=_context.ProductImages.ToList(),
                products=_context.Products
                .Include(p=>p.Category)
                .Include(p=>p.Images)
                .ToList()

            };
            ViewData["title"] = "Sponsorlar";
            ViewData["desc"] = "Biz sirket olafraq emekdasliqa diqqet gosteririk bizi secen sponsorlar asagidakilardir";
            return View(portfolioViewModel);
        }
        public IActionResult Details(int id)
        {
            Product? product = _context.Products
                .Include(p=>p.Category)
                .Include(p=>p.Images)
                .FirstOrDefault(p => p.Id == id);
            if (product == null) throw new ArgumentNullException("tapmadi");
            return View(product);
            
        }
    }
}
