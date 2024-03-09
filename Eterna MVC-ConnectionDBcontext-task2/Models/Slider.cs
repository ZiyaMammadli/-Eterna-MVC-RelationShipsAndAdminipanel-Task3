using System.ComponentModel.DataAnnotations;

namespace Eterna_MVC_ConnectionDBcontext_task2.Models;

public class Slider
{
    public int Id { get; set; }
    [Required]
    [StringLength(40)]
    public string Title1 { get; set; }
    [Required]
    [StringLength(40)]
    public string Title2 { get; set; }
    [Required]
    [StringLength(250)]
    public string image {  get; set; }
    public string Desc { get; set; }
    public string Url { get; set; }
}
