using System.ComponentModel.DataAnnotations;
namespace MyWebSite.Models;

public class FormModel
{
    [Display(Name = "Name")]
    [Required(ErrorMessage = "Enter your name")]
    public string Name { get; set; }
    
    
    [Display(Name = "SecondName")]
    [Required(ErrorMessage = "Enter your second name")]
    public string Surname { get; set; }
    
    
    [Display(Name = "Age")]
    [Required(ErrorMessage = "Enter your age")]
    public int Age { get; set; }
    
    
    [Display(Name = "Email")]
    [Required(ErrorMessage = "Enter your Email")]
    public string Email { get; set; }
    
    
    [Display(Name = "Phone")]
    public string Phone { get; set; }
    
}