using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Api.Models
{
    public class Students
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Grade is required")]
        public string Grade { get; set; }
    }
}
