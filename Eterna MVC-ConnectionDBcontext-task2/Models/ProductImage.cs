using System.ComponentModel.DataAnnotations;

namespace Eterna_MVC_ConnectionDBcontext_task2.Models
{
    public class ProductImage:BaseEntity
    {
        public int ProductId { get; set; }
        [Required]
        [StringLength(250)]
        public string ImageUrl {  get; set; }
        public Product Product { get; set; }
    }
}
