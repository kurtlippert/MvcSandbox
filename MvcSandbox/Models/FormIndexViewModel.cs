using System.ComponentModel.DataAnnotations;

namespace MvcSandbox.Models
{
    public class FormIndexViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}