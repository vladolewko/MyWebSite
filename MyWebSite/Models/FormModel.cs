using System.ComponentModel.DataAnnotations;
namespace MyWebSite.Models;

public class FormModel
{
    [Display(Name = "Ім'я")]
    [Required(ErrorMessage = "Введіть ім'я")]
    [StringLength(20, ErrorMessage = "занадто багато символів")]
    public string Name { get; set; }
    
    
    [Display(Name = "Прізвище")]
    [Required(ErrorMessage = "Введіть прізвище")]
    public string Surname { get; set; }
    
    
    [Display(Name = "Вік")]
    [Required(ErrorMessage = "Введіть вік")]
    public int Age { get; set; }
    
    
    [Display(Name = "Email")]
    [Required(ErrorMessage = "Введіть Email ")]
    public string Email { get; set; }
    
    
    [Display(Name = "Телефон")]
    public string Phone { get; set; }
    
}