using System.ComponentModel.DataAnnotations;

namespace Eterna_MVC_ConnectionDBcontext_task2.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        [StringLength(200)]
        public string Description { get; set; }
    }
}
