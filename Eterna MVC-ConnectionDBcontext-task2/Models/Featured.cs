using System.ComponentModel.DataAnnotations;

namespace Eterna_MVC_ConnectionDBcontext_task2.Models
{
    public class Featured
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        [Required]
        [StringLength(40)]
        public string Title { get; set; }
        [Required]
        [StringLength(140)]
        public string Description { get; set; }

    }
}
