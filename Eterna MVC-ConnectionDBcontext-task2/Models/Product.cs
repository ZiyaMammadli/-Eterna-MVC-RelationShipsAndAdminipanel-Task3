using System.ComponentModel.DataAnnotations;

namespace Eterna_MVC_ConnectionDBcontext_task2.Models
{
    public class Product: BaseEntity
    {
        public int CategoryId { get; set; }
        [Required]
        [StringLength(40)]
        public string Name { get; set; }
        [Required]
        [StringLength(80)]
        public string Client { get; set; }
        [Required]
        [StringLength(250)]
        public string ProjectUrl { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [StringLength(250)]
        public string Description { get; set; }
        public Category? Category { get; set; }
        public ICollection<ProductImage>? Images { get; set; }
        
    }
}
