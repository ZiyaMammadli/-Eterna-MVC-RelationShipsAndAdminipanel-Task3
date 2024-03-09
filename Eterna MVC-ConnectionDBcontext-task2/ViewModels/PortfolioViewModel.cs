using Eterna_MVC_ConnectionDBcontext_task2.Models;

namespace Eterna_MVC_ConnectionDBcontext_task2.ViewModels;

public class PortfolioViewModel
{
    public List<Product> products = new List<Product>();
    public List<ProductImage> productsImages= new List<ProductImage>();
    public List<Category> categories = new List<Category>();
    public List<Client> clients = new List<Client>();
}
