using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Job Name is required")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Job Name must be between 3 and 40 characters long")]
        public string? JobName { get; set; }
        public int EmployerId { get; set; }
        public List<SelectListItem>? Employers { get; set; }

        public AddJobViewModel(List<Employer>employers)
        {
            Employers = new List<SelectListItem>();

            foreach (var employer in employers)
            {
                Employers.Add(new SelectListItem    
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }

        }
        public AddJobViewModel()
        {
        }
    }
}
