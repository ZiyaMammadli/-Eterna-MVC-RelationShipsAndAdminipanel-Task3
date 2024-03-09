using Eterna_MVC_ConnectionDBcontext_task2.Models;

namespace Eterna_MVC_ConnectionDBcontext_task2.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider> sliders = new List<Slider>();
        public List<Featured> features = new List<Featured>();
        public List<About> about = new List<About>();
        public List<Service> services = new List<Service>();
        public List<Client> clients = new List<Client>();
    }
}
