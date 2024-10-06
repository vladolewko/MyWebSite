namespace MyWebSite.Models;
using System.ComponentModel.DataAnnotations;

public class ProductModel
{
    [Key] // Primary Key
    public int Id { get; set; }

    [Required(ErrorMessage = "ProductName is required")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Productname must be between 3 and 100 characters")]
    public string ProductName { get; set; }

    [Required(ErrorMessage = "Description is required")]
    [StringLength(50, MinimumLength = 6, ErrorMessage = "Short Description must be at least 6 characters long")]
    public string ShortDesc { get; set; }
    
    [Required(ErrorMessage = "Description is required")]
    [StringLength(1000, MinimumLength = 50, ErrorMessage = "Description must be at least 50 characters long")]
    public string FullDesc { get; set; }

    [Required(ErrorMessage = "Demention is required")]
    public string Demention { get; set; }
    
    [Required(ErrorMessage = "Weight is required")]
    public int Weight { get; set; }
    
    [Required]
    public float Price { get; set; }

    [Required]
    public bool IsFavorite { get; set; }
    
    public string Image 
    { 
        get { return $"lib/img/ProductImg/{ProductName}.jpg"; }
        
    }
}
