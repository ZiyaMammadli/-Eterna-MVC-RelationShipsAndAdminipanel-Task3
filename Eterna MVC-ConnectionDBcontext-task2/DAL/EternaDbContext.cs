using Eterna_MVC_ConnectionDBcontext_task2.Models;
using Microsoft.EntityFrameworkCore;

namespace Eterna_MVC_ConnectionDBcontext_task2.DAL
{
    public class EternaDbContext: DbContext
    {
        public EternaDbContext(DbContextOptions<EternaDbContext> options) : base(options)
        {
            
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Featured> Featureds { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
    }
}
