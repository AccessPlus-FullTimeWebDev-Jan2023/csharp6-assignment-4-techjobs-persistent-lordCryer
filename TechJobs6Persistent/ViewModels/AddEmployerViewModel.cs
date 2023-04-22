using System.ComponentModel.DataAnnotations;

namespace TechJobs6Persistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 40 characters long")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Location is required")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Location must be between 5 and 50 characters long")]
        public string? Location { get; set; }
    }

   
}
