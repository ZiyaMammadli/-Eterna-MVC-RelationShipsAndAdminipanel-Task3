using System.ComponentModel.DataAnnotations;

namespace Eterna_MVC_ConnectionDBcontext_task2.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Image { get; set; }


    }
}
