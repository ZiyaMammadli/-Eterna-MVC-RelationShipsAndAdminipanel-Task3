using System.ComponentModel.DataAnnotations;

namespace Eterna_MVC_ConnectionDBcontext_task2.Models
{
    public class About
    {
        public int Id { get; set; } 
        public string Image { get; set; }
        [Required]
        [StringLength(80)]
        public string Title { get; set; }
        [Required]
        [StringLength(200)]
        public string Desc1 { get; set; }
        [Required]
        [StringLength(200)]
        public string Desc2 { get; set; }
        [Required]
        [StringLength(200)]
        public string Desc3 { get; set; }
        [Required]
        [StringLength(200)]
        public string Desc4 { get; set; }
        [Required]
        [StringLength(200)]
        public string Desc5 { get; set; }

        
    }
}
