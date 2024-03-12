using System.ComponentModel.DataAnnotations;

namespace Eterna_MVC_ConnectionDBcontext_task2.Models
{
    public class Category:BaseEntity
    {
        [Required]
        [StringLength(40)]
        public string Name { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
